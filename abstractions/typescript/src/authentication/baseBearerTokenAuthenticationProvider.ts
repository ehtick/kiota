import { AccessTokenProvider } from "./accessTokenProvider";
import { AuthenticationProvider } from "./authenticationProvider";

/** Provides a base class for implementing AuthenticationProvider for Bearer token scheme. */
export class BaseBearerTokenAuthenticationProvider implements AuthenticationProvider {
    private static readonly authorizationHeaderKey = "Authorization";

    /**
     * 
     * @param accessTokenProvider 
     */
    public constructor(private accessTokenProvider: AccessTokenProvider) { };

    public authenticateRequest = async (url: string, headers: Map<string, string>): Promise<void> => {
        if (/*custom hosts are provider &&*/!url) {
            throw new Error('Please provide the request url to verify authentication.');
        }
        if (!headers?.has(BaseBearerTokenAuthenticationProvider.authorizationHeaderKey)) {
            const token = await this.accessTokenProvider.getAuthorizationToken(url, headers);
            if (!token) {
                throw new Error('Could not get an authorization token');
            }
            if (!headers) {
                headers = new Map<string, string>();
            }
            headers?.set(BaseBearerTokenAuthenticationProvider.authorizationHeaderKey, `Bearer ${token}`);
        }
    }
}