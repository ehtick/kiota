﻿using System;
using System.IO;
using System.Linq;
using Kiota.Builder.Writers;
using Kiota.Builder.Writers.Php;
using Xunit;

namespace Kiota.Builder.Tests.Writers.Php
{
    public class CodeMethodWriterTests: IDisposable
    {
        private const string DefaultPath = "./";
        private const string DefaultName = "name";
        private readonly StringWriter tw;
        private readonly LanguageWriter writer;
        private readonly CodeMethod method;
        private readonly CodeClass parentClass;
        private const string MethodName = "methodName";
        private const string ReturnTypeName = "Promise";
        private const string MethodDescription = "some description";
        private const string ParamDescription = "some parameter description";
        private const string ParamName = "paramName";
        private readonly CodeMethodWriter _codeMethodWriter;

        public CodeMethodWriterTests()
        {
            writer = LanguageWriter.GetLanguageWriter(GenerationLanguage.PHP, DefaultPath, DefaultName);
            tw = new StringWriter();
            writer.SetTextWriter(tw);
            var root = CodeNamespace.InitRootNamespace();
            root.Name = "Microsoft\\Graph";
            _codeMethodWriter = new CodeMethodWriter(new PhpConventionService());
            parentClass = new CodeClass() {
                Name = "parentClass"
            };
            root.AddClass(parentClass);
            method = new CodeMethod() {
                Name = MethodName,
                IsAsync = true,
                Description = "This is a very good method to try all the good things"
            };
            method.ReturnType = new CodeType() {
                Name = ReturnTypeName
            };
            parentClass.AddMethod(method);
        }
        [Fact]
        public void WriteABasicMethod()
        {
            var declaration = method;
            _codeMethodWriter.WriteCodeElement(declaration, writer);
            var result = tw.ToString();
            Assert.Contains("public function", result);
        }

        [Fact]
        public void WriteMethodWithNoDescription()
        {
            var codeMethod = new CodeMethod()
            {
                Access = AccessModifier.Public,
                Kind = CodeMethodKind.Custom,
                ReturnType = new CodeType()
                {
                    Name = "void"
                }
            };
            _codeMethodWriter.WriteCodeElement(codeMethod, writer);
            var result = tw.ToString();
            
            Assert.DoesNotContain("/*", result);
        }

        public void Dispose()
        {
            tw?.Dispose();
            GC.SuppressFinalize(this);
        }

        [Fact]
        public void WriteRequestExecutor()
        {
            var codeClass = parentClass;
            codeClass.AddProperty(new CodeProperty()
            {
                Kind = CodePropertyKind.RequestAdapter, Name = "requestAdapter"
            });
            codeClass.AddProperty(new CodeProperty()
            {
                Kind = CodePropertyKind.UrlTemplate, Name = "urlTemplate"
            });
            codeClass.AddProperty(new CodeProperty()
            {
                Kind = CodePropertyKind.PathParameters, Name = "pathParameters"
            });
            var codeMethod = new CodeMethod()
            {
                Name = "get",
                HttpMethod = HttpMethod.Post,
                ReturnType = new CodeType()
                {
                    IsExternal = true,
                    Name = "returnType"
                },
                Description = "This will send a POST request",
                Kind = CodeMethodKind.RequestExecutor
            };
            var codeMethodRequestGenerator = new CodeMethod()
            {
                Kind = CodeMethodKind.RequestGenerator,
                HttpMethod = HttpMethod.Post,
                Name = "createPostRequestInformation",
                ReturnType = new CodeType()
                {
                    Name = "RequestInformation"
                }
            };
            codeClass.AddMethod(codeMethod);
            codeClass.AddMethod(codeMethodRequestGenerator);
            
            _codeMethodWriter.WriteCodeElement(codeMethod, writer);
            var result = tw.ToString();

            Assert.Contains("Promise", result);
            Assert.Contains("$requestInfo = $this->createPostRequestInformation();", result);
            Assert.Contains("RejectedPromise", result);
            Assert.Contains("catch(Exception $ex)", result);
        }
        
        [Fact]
        public void WriteSerializer()
        {
            var classHolding = parentClass;
            classHolding.Kind = CodeClassKind.Model;
            classHolding.AddProperty(
                new CodeProperty()
                {
                    Type = new CodeType()
                    {
                        Name = "string"
                    },
                    Name = "name",
                    Access = AccessModifier.Private,
                    Kind = CodePropertyKind.Custom
                });
            classHolding.AddProperty(
                new CodeProperty()
                {
                    Name = "email",
                    Access = AccessModifier.Private,
                    Type = new CodeType()
                    {
                        Name = "EmailAddress"
                    },
                    Kind = CodePropertyKind.Custom
                });
            var codeMethod = new CodeMethod()
            {
                Name = "serialize",
                Kind = CodeMethodKind.Serializer,
                ReturnType = new CodeType()
                {
                    Name = "void",
                }
            };
            codeMethod.AddParameter(new CodeParameter()
            {
                Name = "writer",
                Kind = CodeParameterKind.Serializer,
                Type = new CodeType()
                {
                    Name = "SerializationWriter"
                }
            });
            classHolding.AddMethod(codeMethod);
            _codeMethodWriter.WriteCodeElement(codeMethod, writer);
            var result = tw.ToString();

            Assert.Contains("public function serialize(", result);
            Assert.Contains("$writer->writeStringValue('name', $this->name);", result);
            Assert.Contains("$writer->writeObjectValue('email', $this->email);", result);
        }

        [Fact]
        public void WriteRequestGenerator()
        {
            var methodClass = parentClass;
            methodClass.Kind = CodeClassKind.RequestBuilder;
            methodClass.AddProperty(
                new CodeProperty()
                {
                    Name = "urlTemplate",
                    Access = AccessModifier.Protected,
                    DefaultValue = "https://graph.microsoft.com/v1.0/",
                    Description = "The URL template",
                    Kind = CodePropertyKind.UrlTemplate,
                    Type = new CodeType() {Name = "string"}
                },
                new CodeProperty()
                {
                    Name = "pathParameters",
                    Access = AccessModifier.Protected,
                    DefaultValue = "[]",
                    Description = "The Path parameters.",
                    Kind = CodePropertyKind.PathParameters,
                    Type = new CodeType() {Name = "array"}
                },
                new CodeProperty()
                {
                    Name = "requestAdapter",
                    Access = AccessModifier.Protected,
                    Description = "The request Adapter",
                    Kind = CodePropertyKind.RequestAdapter,
                    Type = new CodeType()
                    {
                        IsNullable = false,
                        Name = "RequestAdapter"
                    }
                });
            var codeMethod = new CodeMethod()
            {
                Name = "createPostRequestInformation",
                ReturnType = new CodeType() {Name = "RequestInformation", IsNullable = false},
                Access = AccessModifier.Public,
                Description = "This method creates request information for POST request.",
                HttpMethod = HttpMethod.Post,
                BaseUrl = "https://graph.microsoft.com/v1.0/",
                Kind = CodeMethodKind.RequestGenerator,
            };
            
            codeMethod.AddParameter(
                new CodeParameter()
                {
                    Name = "body",
                    Kind = CodeParameterKind.RequestBody,
                    Type = new CodeType()
                    {
                        Name = "Message",
                        IsExternal = true,
                        IsNullable = false
                    }
                },
                new CodeParameter() 
                {
                    Name = "headers",
                    Kind = CodeParameterKind.Headers,
                    Type = new CodeType()
                    {
                        Name = "array"
                    }
                
                },
                new CodeParameter()
                {
                    Name = "options",
                    Kind = CodeParameterKind.Options,
                    Type = new CodeType()
                    {
                        Name = "array"
                    }
                });

            
            methodClass.AddMethod(codeMethod);
            
            _codeMethodWriter.WriteCodeElement(codeMethod, writer);
            var result = tw.ToString();

            Assert.Contains(
                "public function createPostRequestInformation(Message $body, array $headers, array $options): RequestInformation",
                result);
            Assert.Contains("return $requestInfo;", result);
            Assert.Contains("$requestInfo->addRequestOptions(...$options);", result);
        }

        [Fact]
        public void WriteIndexerBody()
        {
            var currentClass = parentClass;

            currentClass.AddProperty(
                new CodeProperty()
                {
                    Name = "pathParameters",
                    Kind = CodePropertyKind.PathParameters,
                    Type = new CodeType() {Name = "array"}
                },
                new CodeProperty()
                {
                    Name = "requestAdapter",
                    Kind = CodePropertyKind.RequestAdapter,
                    Type = new CodeType()
                    {
                        Name = "requestAdapter"
                    }
                }
            );
            var codeMethod = new CodeMethod()
            {
                Name = "messageById",
                Access = AccessModifier.Public,
                Kind = CodeMethodKind.IndexerBackwardCompatibility,
                Description = "Get messages by a specific ID.",
                OriginalIndexer = new CodeIndexer()
                {
                    Name = "messageById",
                    ParameterName = "message_id",
                    IndexType = new CodeType()
                    {
                        Name = "MessageRequestBuilder"
                    }
                },
                OriginalMethod = new CodeMethod()
                {
                    Name = "messageById",
                    Access = AccessModifier.Public,
                    Kind = CodeMethodKind.IndexerBackwardCompatibility,
                    ReturnType = new CodeType()
                    {
                        Name = "MessageRequestBuilder"
                    }
                },
                ReturnType = new CodeType()
                {
                    Name = "MessageRequestBuilder",
                    IsNullable = false,
                    TypeDefinition = new CodeClass()
                    {
                        Name = "MessageRequestBuilder",
                        Kind = CodeClassKind.RequestBuilder,
                    }
                }
            };
            codeMethod.AddParameter(new CodeParameter()
            {
                Name = "id",
                Type = new CodeType()
                {
                    Name = "string",
                    IsNullable = false
                }
            });

            currentClass.AddMethod(codeMethod);
            
            _codeMethodWriter.WriteCodeElement(codeMethod, writer);
            var result = tw.ToString();

            Assert.Contains("$urlTplParams['message_id'] = $id;", result);
            Assert.Contains("public function messageById(string $id): MessageRequestBuilder {", result);
            Assert.Contains("return new MessageRequestBuilder($urlTplParams, $this->requestAdapter);", result);

        }

        [Fact]
        public void WriteDeserializer()
        {
            var currentClass = parentClass;
            currentClass.Kind = CodeClassKind.Model;
            currentClass.AddProperty(
                new CodeProperty()
                {
                    Name = "name",
                    Access = AccessModifier.Private,
                    Kind = CodePropertyKind.Custom,
                    Type = new CodeType() {Name = "string"}
                }
            );
            var deserializerMethod = new CodeMethod()
            {
                Name = "getDeserializationFields",
                Kind = CodeMethodKind.Deserializer,
                Description = "Just some random method",
                ReturnType = new CodeType()
                {
                    IsNullable = false,
                    CollectionKind = CodeTypeBase.CodeTypeCollectionKind.Array,
                    Name = "array"
                }
            };
            currentClass.AddMethod(deserializerMethod);
            
            _codeMethodWriter.WriteCodeElement(deserializerMethod, writer);
            var result = tw.ToString();

            Assert.Contains("'name' => function (ParentClass $o, string $n) { $o->setName($n); },", result);
        }

        [Fact]
        public void WriteDeserializerMergeWhenHasParent()
        {
            var currentClass = parentClass;
            currentClass.Kind = CodeClassKind.Model;
            var declaration = currentClass.StartBlock as ClassDeclaration;
            declaration.Inherits = new CodeType() {Name = "Entity", IsExternal = true, IsNullable = false};
            currentClass.AddProperty(
                new CodeProperty()
                {
                    Name = "name",
                    Access = AccessModifier.Private,
                    Kind = CodePropertyKind.Custom,
                    Type = new CodeType() {Name = "string"}
                }
            );
            var deserializerMethod = new CodeMethod()
            {
                Name = "getDeserializationFields",
                Kind = CodeMethodKind.Deserializer,
                Description = "Just some random method",
                ReturnType = new CodeType()
                {
                    IsNullable = false,
                    CollectionKind = CodeTypeBase.CodeTypeCollectionKind.Array,
                    Name = "array"
                }
            };
            currentClass.AddMethod(deserializerMethod);
            
            _codeMethodWriter.WriteCodeElement(deserializerMethod, writer);
            var result = tw.ToString();

            Assert.Contains("array_merge(parent::getFieldDeserializers()", result);
        }

        [Fact]
        public void WriteConstructorBody()
        {
            var constructor = new CodeMethod()
            {
                Name = "constructor",
                Access = AccessModifier.Public,
                Description = "The constructor for this class",
                ReturnType = new CodeType() {Name = "void"},
                Kind = CodeMethodKind.Constructor
            };
            var closingClass = parentClass;
            parentClass.AddMethod(constructor);
            
            _codeMethodWriter.WriteCodeElement(constructor, writer);
            var result = tw.ToString();

            Assert.Contains("public function __construct", result);
        }

        [Fact]
        public void WriteGetter()
        {
            var getter = new CodeMethod()
            {
                Name = "getEmailAddress",
                Description = "This method gets the emailAddress",
                ReturnType = new CodeType()
                {
                    Name = "emailAddress",
                    IsNullable = false
                },
                Kind = CodeMethodKind.Getter,
                AccessedProperty = new CodeProperty() {Name = "emailAddress", Access = AccessModifier.Private, Type = new CodeType()
                {
                    Name = "emailAddress"
                }}
            };

            _codeMethodWriter.WriteCodeElement(getter, writer);
            var result = tw.ToString();
            Assert.Contains(": EmailAddress {", result);
            Assert.Contains("public function getEmailAddress", result);
        }

        [Fact]
        public void WriteSetter()
        {
            var setter = new CodeMethod()
            {
                Name = "setEmailAddress",
                ReturnType = new CodeType()
                {
                    Name = "void"
                },
                Kind = CodeMethodKind.Setter,
                AccessedProperty = new CodeProperty() {Name = "emailAddress", Access = AccessModifier.Private, Type = new CodeType()
                {
                    Name = "emailAddress"
                }},

            };
            
            setter.AddParameter(new CodeParameter()
            {
                Name = "value",
                Kind = CodeParameterKind.SetterValue,
                Type = new CodeType()
                {
                    Name = "emailAddress"
                }
            });
            _codeMethodWriter.WriteCodeElement(setter, writer);
            var result = tw.ToString();

            Assert.Contains("public function setEmailAddress(EmailAddress $value)", result);
            Assert.Contains(": void {", result);
            Assert.Contains("$this->emailAddress = $value", result);
        }

        [Fact]
        public void WriteRequestBuilderWithParametersBody()
        {
            var codeMethod = new CodeMethod()
            {
                ReturnType = new CodeType()
                {
                    Name = "MessageRequestBuilder",
                    IsNullable = false
                },
                Name = "message",
                Kind = CodeMethodKind.RequestBuilderWithParameters
            };
            
            codeMethod.AddParameter(new CodeParameter()
            {
                Kind = CodeParameterKind.PathParameters,
                Name = "someParameter",
                Type = new CodeType()
                {
                    Name = "array"
                },
                UrlTemplateParameterName = "rawUrl"
            });
            
            _codeMethodWriter.WriteCodeElement(codeMethod, writer);
            var result = tw.ToString();
            Assert.Contains("function message(array $pathParameters): MessageRequestBuilder {", result);
            Assert.Contains("return new MessageRequestBuilder($this->pathParameters, $this->requestAdapter);", result);
        }
    }
}
