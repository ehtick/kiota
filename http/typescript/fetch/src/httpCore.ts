import { AuthenticationProvider, BackingStoreFactory, BackingStoreFactorySingleton, HttpCore as IHttpCore, Parsable, ParseNodeFactory, RequestInfo, ResponseHandler, ParseNodeFactoryRegistry, enableBackingStoreForParseNodeFactory, SerializationWriterFactoryRegistry, enableBackingStoreForSerializationWriterFactory, SerializationWriterFactory } from '@microsoft/kiota-abstractions';
import { Headers as FetchHeadersCtor } from 'cross-fetch';
import { ReadableStream } from 'web-streams-polyfill';
import { URLSearchParams } from 'url';
import { HttpClient } from './httpClient';
import { RequestConfig } from './RequestConfig';
export class HttpCore implements IHttpCore {
    public getSerializationWriterFactory(): SerializationWriterFactory {
        return this.serializationWriterFactory;
    }
    /**
     * Instantiates a new http core service
     * @param authenticationProvider the authentication provider to use.
     * @param parseNodeFactory the parse node factory to deserialize responses.
     * @param serializationWriterFactory the serialization writer factory to use to serialize request bodies.
     * @param httpClient the http client to use to execute requests.
     */
    public constructor(public readonly authenticationProvider: AuthenticationProvider, private parseNodeFactory: ParseNodeFactory = ParseNodeFactoryRegistry.defaultInstance, private serializationWriterFactory: SerializationWriterFactory = SerializationWriterFactoryRegistry.defaultInstance, private readonly httpClient: HttpClient = new HttpClient()) {
        if (!authenticationProvider) {
            throw new Error('authentication provider cannot be null');
        }
        if (!parseNodeFactory) {
            throw new Error('parse node factory cannot be null');
        }
        if (!serializationWriterFactory) {
            throw new Error('serialization writer factory cannot be null');
        }
        if (!httpClient) {
            throw new Error('http client cannot be null');
        }
    }
    private getResponseContentType = (response: Response): string | undefined => {
        const header = response.headers.get("content-type")?.toLowerCase();
        if (!header) return undefined;
        const segments = header.split(';');
        if (segments.length === 0) return undefined;
        else return segments[0];
    }
    public sendCollectionAsync = async <ModelType extends Parsable>(requestInfo: RequestInfo, type: new () => ModelType, responseHandler: ResponseHandler | undefined): Promise<ModelType[]> => {
        if (!requestInfo) {
            throw new Error('requestInfo cannot be null');
        }
        await this.authenticationProvider.authenticateRequest(requestInfo);

        const request = this.getRequestFromRequestInfo(requestInfo);
        const response = await this.httpClient.fetch(this.getRequestUrl(requestInfo), request);
        if (responseHandler) {
            return await responseHandler.handleResponseAsync(response);
        } else {
            const payload = await response.arrayBuffer();
            const responseContentType = this.getResponseContentType(response);
            if (!responseContentType)
                throw new Error("no response content type found for deserialization");

            const rootNode = this.parseNodeFactory.getRootParseNode(responseContentType, payload);
            const result = rootNode.getCollectionOfObjectValues(type);
            return result as unknown as ModelType[];
        }
    }
    public sendAsync = async <ModelType extends Parsable>(requestInfo: RequestInfo, type: new () => ModelType, responseHandler: ResponseHandler | undefined): Promise<ModelType> => {
        if (!requestInfo) {
            throw new Error('requestInfo cannot be null');
        }
        await this.authenticationProvider.authenticateRequest(requestInfo);

        const request = this.getRequestFromRequestInfo(requestInfo);
        const response = await this.httpClient.fetch(this.getRequestUrl(requestInfo), request);
        if (responseHandler) {
            return await responseHandler.handleResponseAsync(response);
        } else {
            const payload = await response.arrayBuffer();
            const responseContentType = this.getResponseContentType(response);
            if (!responseContentType)
                throw new Error("no response content type found for deserialization");

            const rootNode = this.parseNodeFactory.getRootParseNode(responseContentType, payload);
            const result = rootNode.getObjectValue(type);
            return result as unknown as ModelType;
        }
    }
    public sendPrimitiveAsync = async <ResponseType>(requestInfo: RequestInfo, responseType: "string" | "number" | "boolean" | "Date" | "ReadableStream", responseHandler: ResponseHandler | undefined): Promise<ResponseType> => {
        if (!requestInfo) {
            throw new Error('requestInfo cannot be null');
        }
        await this.authenticationProvider.authenticateRequest(requestInfo);

        const request = this.getRequestFromRequestInfo(requestInfo);
        const response = await this.httpClient.fetch(this.getRequestUrl(requestInfo), request);
        if (responseHandler) {
            return await responseHandler.handleResponseAsync(response);
        } else {
            switch (responseType) {
                case "ReadableStream":
                    const buffer = await response.arrayBuffer();
                    let bufferPulled = false;
                    const stream = new ReadableStream({
                        pull: (controller) => {
                            if (!bufferPulled) {
                                controller.enqueue(buffer.slice(0))
                                bufferPulled = true;
                            }
                        },
                    });
                    return stream as unknown as ResponseType;
                case 'string':
                case 'number':
                case 'boolean':
                case 'Date':
                    const payload = await response.arrayBuffer();
                    const responseContentType = this.getResponseContentType(response);
                    if (!responseContentType)
                        throw new Error("no response content type found for deserialization");

                    const rootNode = this.parseNodeFactory.getRootParseNode(responseContentType, payload);
                    if (responseType === 'string') {
                        return rootNode.getStringValue() as unknown as ResponseType;
                    } else if (responseType === 'number') {
                        return rootNode.getNumberValue() as unknown as ResponseType;
                    } else if (responseType === 'boolean') {
                        return rootNode.getBooleanValue() as unknown as ResponseType;
                    } else if (responseType === 'Date') {
                        return rootNode.getDateValue() as unknown as ResponseType;
                    } else {
                        throw new Error("unexpected type to deserialize");
                    }
            }
        }
    }
    public sendNoResponseContentAsync = async (requestInfo: RequestInfo, responseHandler: ResponseHandler | undefined): Promise<void> => {
        if (!requestInfo) {
            throw new Error('requestInfo cannot be null');
        }
        await this.authenticationProvider.authenticateRequest(requestInfo);

        const request = this.getRequestFromRequestInfo(requestInfo);
        const response = await this.httpClient.fetch(this.getRequestUrl(requestInfo), request);
        if (responseHandler) {
            return await responseHandler.handleResponseAsync(response);
        }
    }
    public enableBackingStore = (backingStoreFactory?: BackingStoreFactory | undefined): void => {
        this.parseNodeFactory = enableBackingStoreForParseNodeFactory(this.parseNodeFactory);
        this.serializationWriterFactory = enableBackingStoreForSerializationWriterFactory(this.serializationWriterFactory);
        if (!this.serializationWriterFactory || !this.parseNodeFactory)
            throw new Error("unable to enable backing store");
        if (backingStoreFactory) {
            BackingStoreFactorySingleton.instance = backingStoreFactory;
        }
    }
    private getRequestFromRequestInfo = (requestInfo: RequestInfo): RequestInit => {
        const request = {
            method: requestInfo.httpMethod?.toString(),
            headers: new FetchHeadersCtor(),
            body: requestInfo.content,
        } as RequestInit;
        requestInfo.headers?.forEach((v, k) => (request.headers as Headers).set(k, v));
        return request;
    }
    private getRequestUrl = (requestInfo: RequestInfo): string => {
        let url = requestInfo.URI ?? '';
        if (requestInfo.queryParameters?.size ?? -1 > 0) {
            const queryParametersBuilder = new URLSearchParams();
            requestInfo.queryParameters?.forEach((v, k) => {
                queryParametersBuilder.append(k, `${v}`);
            });
            url = url + '?' + queryParametersBuilder.toString();
        }
        return url;
    }

    public CoreInit(options: RequestConfig) {

    }

}