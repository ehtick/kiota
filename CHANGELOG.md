# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

<!-- markdownlint-disable-file MD024 -->

## [Unreleased]

### Added

### Changed

## [1.28.0] - 2025-07-11

### Added

### Changed

- Removed incomplete Swift generation.
- Removed CLI generation ability. [microsoft/kiota-cli-commons#248](https://github.com/microsoft/kiota-cli-commons/issues/248)
- Fixed a bug where union of primitive types collection would not compile in dotnet. [#6635](https://github.com/microsoft/kiota/issues/6635)
- Fixes generation of usings/imports in where Date Types are placed in a nested class. [#6286](https://github.com/microsoft/kiota/issues/6286)
- Python: Set a default value for non-nullable array fields. [#6350](https://github.com/microsoft/kiota/issues/6350)
- Fixed a bug causing an error in generation of requests which have an enum or an UntypedNode as body. [microsoft/kiota-dotnet#537](https://github.com/microsoft/kiota-dotnet/issues/537)
- Removed redundant additional data property definition in TypeScript.
- Fixed a bug where the value parameter for serialization/deserialization in TypeScript methods would be missing a doc comment.
- Fixed a bug where serializing a base type in TypeScript would lead to missing properties from the derived type. [#6511](https://github.com/microsoft/kiota/issues/6511)

## [1.27.0] - 2025-06-11

### Added

### Changed

- Fixed a bug where TypeScript clients instantiation would fail. [#6597](https://github.com/microsoft/kiota/issues/6597)
- Fixed a bug where path items with a trailing slash would cause collisions, missing query parameters and more.
- Fixed a bug where path items with a trailing slash would be missing query parameters. [#6569](https://github.com/microsoft/kiota/issues/6569)
- Fixed an issue where migration from lock to workspace would fail because of stream management. [#6515](https://github.com/microsoft/kiota/issues/6515)
- Fixed a bug where media types from error responses would be missing from the accept header. [#6572](https://github.com/microsoft/kiota/issues/6572)
- Fixed a bug where serialization names for Dart were not correct [#6624](https://github.com/microsoft/kiota/issues/6624)
- Fixed a bug where imports from __future__ would appear below other imports in python generated code. [#4600](https://github.com/microsoft/kiota/issues/4600)

## [1.26.1] - 2025-05-15

### Added

- Added support for windows arm64. [#6427](https://github.com/microsoft/kiota/issues/6427)

### Changed

- Fixed a bug where having `additionalProperties` schema (instead of true) would not generate `AdditionalData` property. [#6443](https://github.com/microsoft/kiota/issues/6443)
- Fixed a bug where escaped line breaks and/or double quotes defined in the schema object properties would break the generation of CSharp client [#6472](https://github.com/microsoft/kiota/issues/6472)

## [1.26.0] - 2025-05-06

### Added

- Support for `--no-workspace` option in the CLI plugin add command to avoid using the workspace experience. [#6452](https://github.com/microsoft/kiota/issues/6452)

### Changed

- Fixed a bug where Dart properties casing would change for serialization.
- Fixed a bug where default response definitions were being considered for Media Type selection [#6413](https://github.com/microsoft/kiota/issues/6413)

## [1.25.1] - 2025-04-03

### Changed

- Fixed a bug with http client generation where query parameters were being processed incorrectly. [#6268](https://github.com/microsoft/kiota/issues/6268)

### Added

- Extracted and created an npm package from the VS Code - Kiota interop module. [#6172](https://github.com/microsoft/kiota/pull/6172)

- Added support for generating function capabilities in plugin manifest from x-ai-capabilities OpenApi extension. [#6369](https://github.com/microsoft/kiota/issues/6369)

- Added a comment on top of every golang file to indicate the file is machine generated so it can be excluded from various tools. [#6363](https://github.com/microsoft/kiota/issues/6363)

### Changed

- Fixed a bug with creating the correct runtime with auth using http bearer security scheme or when root auth is set. [#6357](https://github.com/microsoft/kiota/issues/6357)

## [1.24.3] - 2025-03-26

### Changed

- Fixed a bug with reading adaptive card OpenAPI extension and writing to plugin manifest. [#6351](https://github.com/microsoft/kiota/issues/6351)
- Fixed a critical bug with the vscode integration and the JSON RPC server.

## [1.24.2] - 2025-03-25

### Added

### Changed

- Fixed a bug following OpenAPI 3.1 support that lead to false warnings about unknown type/format pairs. [#6270](https://github.com/microsoft/kiota/issues/6270)
- Fixed a bug where security scheme would be missing from plugins OpenAPI descriptions. [#6279](https://github.com/microsoft/kiota/issues/6279)
- Fixed pet store description source.

## [1.24.1] - 2025-03-13

### Changed

- Fixed docker images publishing

## [1.24.0] - 2025-03-12

### Added

- Added support for OpenAPI 3.1. [#3914](https://github.com/microsoft/kiota/issues/3914)

### Changed

- Fixed mapping of Binary Types to array buffer in TypeScript. [#6124](https://github.com/microsoft/kiota/issues/6124)
- Updated kiota generate classname flag validator to prevent invalid class names. [#6187](https://github.com/microsoft/kiota/issues/6187)
- Fixed enum serialization for union and intersection types in Dart. [#6201](https://github.com/microsoft/kiota/pull/6201)
- Added mapping for Bundle package in PHP to show up in Kiota commands. [#4636](https://github.com/microsoft/kiota/issues/4636)
- Fixes javadoc warning present in generated Java code comments due to the presence of special XML character.

## [1.23.0] - 2025-02-06

### Added

- Added support for net9 only installations of the dotnet tool. [#5887](https://github.com/microsoft/kiota/issues/5887)

### Changed

- Fixes serialization of collection of enums. [microsoft/kiota-typescript#1276](https://github.com/microsoft/kiota-typescript/issues/1276)

## [1.22.3]

### Added

- Added dart generation to Visual Studio Code extension.

### Changed

- Fixed a bug in the VS Code extension deeplink with the API Center extension [#6004](https://github.com/microsoft/kiota/issues/6004)
- Drops Python 3.8 support by removing deprecated type aliases from generated code. [microsoft/kiota-python#349](https://github.com/microsoft/kiota-python/issues/349)
- Removes superfluous inline imports in serializer methods in Python Generation.

## [1.22.2]

### Added

### Changed

- Fixed a bug showing an error popup in the VS Code extension after generation [5988](https://github.com/microsoft/kiota/issues/5988)

## [1.22.1] - 2025-01-10

### Added

### Changed

- Fixed a bug in the VS Code extension plugin generation [#5978](https://github.com/microsoft/kiota/issues/5978)

## [1.22.0] - 2025-01-09

### Added

- Adds code generation for the `Dart` programming language.Credit to @ricardoboss, @joanne-ter-maat, @Kees-Schotanus, @andreaTP, @baywet[#3745](https://github.com/microsoft/kiota/issues/3745)
- Added new linux arm64 binary builds for Kiota CLI

### Changed

- Fixed a bug in generation when a referenced schema in an allOf was a primitive [#5701](https://github.com/microsoft/kiota/issues/5701).
- Fixed a bug where inherited error models would be missing interface declarations. [#5888](https://github.com/microsoft/kiota/issues/5888)
- Fixed a bug where oneOf/anyOf schemas with single references to inheritance or intersections would be missing properties. [#5921](https://github.com/microsoft/kiota/issues/5921)

## [1.21.0] - 2024-12-05

### Added

- Added a notion of support experience for languages in preparation for new community implemented languages.

### Changed

- Fixed python generation in scenarios with opening/closing tags for code comments. [#5636](https://github.com/microsoft/kiota/issues/5636)
- Fixed Python error when a class inherits from a base class and implements an interface. [#5637](https://github.com/microsoft/kiota/issues/5637)
- Fixed a bug where one/any schemas with single schema entries would be missing properties. [#5808](https://github.com/microsoft/kiota/issues/5808)
- Fixed anyOf/oneOf generation in TypeScript. [5353](https://github.com/microsoft/kiota/issues/5353)
- Fixed invalid code in Php caused by "*/*/" in property description. [5635](https://github.com/microsoft/kiota/issues/5635)
- Fixed a bug where discriminator property name lookup could end up in an infinite loop. [#5771](https://github.com/microsoft/kiota/issues/5771)
- Fixed TypeScript generation error when generating usings from shaken serializers. [#5634](https://github.com/microsoft/kiota/issues/5634)
- Multiple fixed and improvements in OpenAPI description generation for plugins. [#5806](https://github.com/microsoft/kiota/issues/5806)

## [1.20.0] - 2024-11-07

### Added

### Changed

- Fixed python generation client serailization failure str being quoted as "str"
- Fixed Issue with primitive values being stringified in python python. [#5417](https://github.com/microsoft/kiota/issues/5417)
- Fixed an issue where multipart request content would be ignored if other unstructured content was present in the description. [#5638](https://github.com/microsoft/kiota/issues/5638)
- Fixed an issue where when generating Go code the deserializer for unions was using `CodeClass` as a filter and not `CodeInterface`. [#4844](https://github.com/microsoft/kiota/issues/4844)
- Fixes mapping of `int16` format to the `integer` type rather than `double` when the type is `integer` or `number` [#5611](https://github.com/microsoft/kiota/issues/5611)
- Fixed a bug where default boolean values with quotes would fail in Java/PHP/CSharp/Go.
- Fixed a bug where composed types wrappers would not build in CSharp.
- Fixed a bug where the type name for inherited inline models would be incorrect. [#5610](https://github.com/microsoft/kiota/issues/5610)
- Fixes typing inconsistencies in generated code and libraries in Python [kiota-python#333](https://github.com/microsoft/kiota-python/issues/333)
- Fixes generation of superfluous fields for Models with discriminator due to refiners adding the same properties to the same model [#4178](https://github.com/microsoft/kiota/issues/4178).
- Fixes unsigned shim binary when installed as dotnet tool [#5650](https://github.com/microsoft/kiota/issues/5650).

## [1.19.1] - 2024-10-11

### Added

### Changed

- Fixed incompatibility with detecting odata primitives after conversion library updates at [OpenAPI.NET.OData#581](https://github.com/microsoft/OpenAPI.NET.OData/issues/581);
- Fixed cyclic dependencies in generated Go code. [#2834](https://github.com/microsoft/kiota/issues/2834)
- Fixed a bug where default output folder is created on plugin edit and generate commands. [#5510](https://github.com/microsoft/kiota/issues/5429)
- Changed GeneratedCode attribute applied when generating CSharp to only include the major version of Kiota. [#5489](https://github.com/microsoft/kiota/issues/5489)

- Fixed generating CSharp client displays clean hint regardless of whether --clean-output is already passed [#5576](https://github.com/microsoft/kiota/issues/5576)

## [1.19.0] - 2024-10-03

### Added

- Control generated type access modifier for C# via `--type-access-modifier` flag. [#4788](https://github.com/microsoft/kiota/issues/4788)

### Changed

- 📢📢📢 The Visual Studio Code extension is now generally available!. [#5368](https://github.com/microsoft/kiota/issues/5368)
- Fixed a stack overflow in the core generator caused by circular comparisons. [#5369](https://github.com/microsoft/kiota/issues/5369)
- Fixed a bug where a path segment named "item" after a single parameter path segment would derail generation. [#4814](https://github.com/microsoft/kiota/issues/4814)
- Fixed a bug where collection/array of primitive types members for union/intersection types would be ignored. [#5283](https://github.com/microsoft/kiota/issues/5283)
- Updated dependencies command and view to reflect the availability of bundles. [#5317](https://github.com/microsoft/kiota/issues/5317)
- Fixed a bug when generating a plugin when only an operation is selected in the root node in the extension. [#5300](https://github.com/microsoft/kiota/issues/5300)
- Fixed a bug where function descriptions in plugin manifest defaults to path summary instead of description. [#5301](https://github.com/microsoft/kiota/issues/5301)
- Fixed a bug where TypeScript would not properly build URIs with uppercase first characters query parameter names.[#5382](https://github.com/microsoft/kiota/issues/5382)
- Fixed a bug where the description special characters are encoded. [#5286](https://github.com/microsoft/kiota/issues/5286)
- Fixed a bug where python constructor parameters are being cast to strings leading to bugs as the types is unknown on graph call. [microsoftgraph/msgraph-sdk-python#165](https://github.com/microsoftgraph/msgraph-sdk-python/issues/165)
- Fixed a bug where child path segment from single parameter path segment would be incorrectly escaped. [#5433](https://github.com/microsoft/kiota/issues/5433)
- Fixed inconsistent typing information generated for `ParsableFactory` and stream return types in python [kiota-abstractions-python#533](https://github.com/microsoft/kiota-abstractions-python/issues/333)
- Fixed a bug where untyped not imports in TypeScripts would not be erasable. [microsoft/kiota-typescript#1381](https://github.com/microsoft/kiota-typescript/issues/1381)
- Updated schema link in plugin manifest to the correct url. [#5441](https://github.com/microsoft/kiota/issues/5441)
- Removed registration of default serialization and deserialization classes in client constructor. [#5478](https://github.com/microsoft/kiota/pull/5478)
- Fixed incorrect type name generation in aliased scenario in TS due to broad searching of types in root namespaces. [#5404](https://github.com/microsoft/kiota/issues/5404)
- Fixed incorrect type mapping in request builders with subsequent paths with the same name. [#5462](https://github.com/microsoft/kiota/issues/5462)
- Fixed multipart generation to default Content-Types are defined for multipart [#5504](https://github.com/microsoft/kiota/issues/5504)

## [1.18.0] - 2024-09-05

### Added

- Added the ability to export the CodeDom to a file showing the public APIs to be generated in a given language [#4627](https://github.com/microsoft/kiota/issues/4627)
- Added composed type serialization in Typescript [2462](https://github.com/microsoft/kiota/issues/2462)
- Use authentication information available in the source OpenAPI document when generating a plugin manifest. [#5070](https://github.com/microsoft/kiota/issues/5070)

### Changed

- Fixed shorthand for refresh option in workspace experience. [#5240](https://github.com/microsoft/kiota/issues/5240)
- Fixed a bug where untyped node imports would be missing CSharp/Go/TypeScript/Java. [#5326](https://github.com/microsoft/kiota/issues/5326)
- Fixed missing type options in help for plugin commands. [#5230](https://github.com/microsoft/kiota/issues/5230)
- Removed OpenAI plugins generation since the service does not support them anymore.
- Fixed a bug where a nullable union type would lead to an exception at generation. [#5276](https://github.com/microsoft/kiota/issues/5276)
- Fixed a bug where the error message would not be deserialized if the property name matched a reserved property. [#5311](https://github.com/microsoft/kiota/issues/5311)
- Fixed an issue where TypeScript clients would be missing path parameters. [#5247](https://github.com/microsoft/kiota/issues/5247)
- Fixed a bug where names normalization could lead to collisions in Ruby and other languages. [#5310](https://github.com/microsoft/kiota/issues/5310)
- Redirect status codes documenting an application/octet-stream content type now generate a stream return type. [#5246](https://github.com/microsoft/kiota/issues/5246)
- Fixed an issue where models would be missing when they had no properties and a single allOf entry. [#5014](https://github.com/microsoft/kiota/issues/5014)
- Reverts modification of responses in output openApi file when generating plugins [#4945](https://github.com/microsoft/kiota/issues/4945)
- Expand properties types with null type for Typescript. [#4993](https://github.com/microsoft/kiota-typescript/issues/1188)
- Added Collection, HashMap, Map, Objects, InputStream, BigDecimal to the list of reserved names for Java generation. [#5135](https://github.com/microsoft/kiota/issues/5135)
- C# refiner now fixes data types for indexers. [#5201](https://github.com/microsoft/kiota/issues/5201)
- C# do not report CS0618 in the generated code. [#5229](https://github.com/microsoft/kiota/issues/5229)
- C# do not decorate method parameter(s) with ObsoleteAttribute. [#5228](https://github.com/microsoft/kiota/issues/5228)
- Fixed an issue where the generation hint for the workspace experience would be outdated. [#5241](https://github.com/microsoft/kiota/issues/5241)
- Fixes an issue where the GoPathSegmenter would create the same file name for different elements to lead to missing code due to overwriting of the content [#4833](https://github.com/microsoft/kiota/issues/4833)

## [1.17.0] - 2024-08-09

### Added

- Adds generation of default `color.png` and `outline.png` files when generating plugins. [#4993](https://github.com/microsoft/kiota/issues/4993)

### Changed

- Fixed a bug where properties would be missing in Python models if they didn't have additional properties. [#5037](https://github.com/microsoft/kiota/issues/5037)
- Fixed a bug in dotnet where CS1587 warnings are generated in generated enums with descriptions [#4957](https://github.com/microsoft/kiota/issues/4957)
- Fixed a bug where the copilot teams toolkit integration would serialize empty declarative copilots. [#4974](https://github.com/microsoft/kiota/issues/4974)
- Fixed a bug for the docker image where the volume path would not match the expected configuration for the description.
- Fixed a bug in Go where certain namespaces were escaped unexpectedly. [#5012](https://github.com/microsoft/kiota/issues/5012)
- Exclude the `x-openai-isConsequential` extension from cleanup. [#4962](https://github.com/microsoft/kiota/issues/4962)
- Fixed file name and namespace sanitization when generating plugins. [#5019](https://github.com/microsoft/kiota/issues/5019)
- Added TypeScript type check suppression to generated method prototype, where unused arguments can cause build fail in projects which use `noUnusedLocals: true` compiler option. [#5095](https://github.com/microsoft/kiota/issues/5095)
- Fixed a bug where defensive programming would consider some default values as invalid in Python.

## [1.16.0] - 2024-07-05

### Added

### Changed

- Implemented partial class model declarations. [4894](https://github.com/microsoft/kiota/issues/4894)
- Fixed a bug where the Go file names were too long
- Fixed a bug where the declarative copilot information would be erased if any. [#4935](https://github.com/microsoft/kiota/issues/4935)
- Fixes bug with model names in Go generated from camel case namespace. [https://github.com/microsoftgraph/msgraph-sdk-go/issues/721]
- Plugins OpenAPI extensions are only added when generating plugins to reduce the risk of parsing errors. [#4834](https://github.com/microsoft/kiota/issues/4834)
- TypeScript imports are now using ES6 imports with the .js extension.
- Remove LINQ usage in generated code.
- Ensures descriptions are not empty in sliced OpenApi file when generating a plugin.
- Plugins do not emit parameters anymore. [#4841](https://github.com/microsoft/kiota/issues/4841)
- References to C# types generated by kiota are prefixed with `global::` to avoid name collisions. [#4796](https://github.com/microsoft/kiota/issues/4796)
- Ensures HashSet properties in `KiotaLock` maintain IgnoreCase comparer across runs [#4916](https://github.com/microsoft/kiota/issues/4916)
- Dropped `client base url set to` message when generating plugins. [#4905](https://github.com/microsoft/kiota/issues/4905)
- Emit `[GeneratedCode]` attribute for C# types. [#4907](https://github.com/microsoft/kiota/issues/4907)
- Fixes error property disambiguation when the property has the same name as class [#4893](https://github.com/microsoft/kiota/issues/)
- Fixes missing imports for `UntypedNode` for method parameter and return value scenarios. [#4925](https://github.com/microsoft/kiota/issues/4925)
- Normalize path separators in lock and workspace files to use `/` as the path separator. [#4228](https://github.com/microsoft/kiota/issues/4228)

## [1.15.0] - 2024-06-06

### Added

- Added support for multipart form data request body in PHP. [#3029](https://github.com/microsoft/kiota/issues/3029)
- Added uri-form encoded serialization for PHP. [#2074](https://github.com/microsoft/kiota/issues/2074)
- Added information message with base URL in the CLI experience. [#4635](https://github.com/microsoft/kiota/issues/4635)
- Added optional parameter --disable-ssl-validation for generate, show, and download commands. [#4176](https://github.com/microsoft/kiota/issues/4176)
- For *Debug* builds of kiota, the `--log-level` / `--ll` option is now observed if specified explicitly on the command line. It still defaults to `Debug` for *Debug* builds and `Warning` for *Release* builds. [#4739](https://github.com/microsoft/kiota/pull/4739)

### Changed

- Fix package casing normalizing for value passed using `--namespace-name` option when generating Go Client. [#4498](https://github.com/microsoft/kiota/issues/4498)
- Aligns naming of sliced OpenAPI description generated by `plugin add` should be named `<plugin-name>-openapi.json|yml` [#4595](https://github.com/microsoft/kiota/issues/4595)
- Fixed RPC server to respect the `KIOTA_CONFIG_PREVIEW` flag.
- Added missing nullable directives for CLI generation.
- Fixed handling of nested arrays to be handled as `UntypedNode` instances [#4549](https://github.com/microsoft/kiota/issues/4549)
- Fixed `InvalidOperationException` thrown when serializing IBacked models with no changes present in the additional data in dotnet [microsoftgraph/msgraph-sdk-dotnet#2471](https://github.com/microsoftgraph/msgraph-sdk-dotnet/issues/2471).
- Fixed a bug where enums could be considered inheritance parents. [#4640](https://github.com/microsoft/kiota/issues/4640)
- Fixed `RequestConfiguration` Classes dropped in RequestBuilder methods in python [#4535](https://github.com/microsoft/kiota/issues/4535)
- Fixed incorrect optional types in method parameters in Python [#4507](https://github.com/microsoft/kiota/issues/4507)
- Changed enum parsing methods to return nil in the default case in Go [#4621](https://github.com/microsoft/kiota/issues/4621)
- Changes the cached description file name to `openapi.yml|json` from `description.yml|json` [#4641](https://github.com/microsoft/kiota/issues/4641)
- Put opening brace after namespace definition on new line [#4625](https://github.com/microsoft/kiota/issues/4625)
- Put opening brace after property definition on new line, if property has getter and setter [#4625](https://github.com/microsoft/kiota/issues/4625)
- Put spaces correctly around dictionary entries [#4625](https://github.com/microsoft/kiota/issues/4625)
- Remove trailing space after class definition [#4625](https://github.com/microsoft/kiota/issues/4625)
- Fixed a bug where multiple allOf entries type would not get merged if they were part of a discriminator. [#4325](https://github.com/microsoft/kiota/issues/4325)
- Fixed a bug where allOf structure with one entry and properties would not be considered as inheritance case. [#4346](https://github.com/microsoft/kiota/issues/4346)
- Fixed a bug where some allOf scenarios would be missing properties if type object wasn't set on the schema. [#4074](https://github.com/microsoft/kiota/issues/4074)
- Fixed a bug where schema with multiple allOf entries would incorrectly get merged to inherit from the first entry [#4428](https://github.com/microsoft/kiota/issues/4428)
- Fixes constructor generation for nullable properties that are initialized as null in C#,Java and PHP
- Fixed a bug where the hash alias in typescript wasn't being generated uniformly for similar interfaces [microsoftgraph/msgraph-beta-sdk-typescript#84](https://github.com/microsoftgraph/msgraph-beta-sdk-typescript/issues/84)
- Fixes a bug where name collisions would occur in the Typescript refiner if model name also exists with the `Interface` suffix [#4382](https://github.com/microsoft/kiota/issues/4382)
- Fixes a bug where paths without operationIds would not be included in the generated plugins and ensured operationIds are cleaned up [#4642](https://github.com/microsoft/kiota/issues/4642)
- Fixes a bug where models would be duplicated in some allOf scenarios [#4191](https://github.com/microsoft/kiota/issues/4191)
- Fixes a bug where CLI Generation does not handle path parameters of type "string" and format "date", "date-time", "time", etc. [#4615](https://github.com/microsoft/kiota/issues/4615)
- Fixes a bug where request executors would be missing Untyped parameters in dotnet [#4692](https://github.com/microsoft/kiota/issues/4692)
- Fixes a bug where indexers in include/exclude patters were not normalized if the indexer was the last segment without a slash at the end [#4715](https://github.com/microsoft/kiota/issues/4715)
- Fixes a bug where CLI generation doesn't handle parameters of type string array. [#4707](https://github.com/microsoft/kiota/issues/4707)
- Fixed a bug where models would not be created when a multipart content schema existed with no encoding [#4734](https://github.com/microsoft/kiota/issues/4734)
- Types generated by Kiota are now referenced with their full name to avoid namespace ambiguities [#4475](https://github.com/microsoft/kiota/issues/4475)
- Fixes a bug where warnings about discriminator not being inherited were generated [#4761](https://github.com/microsoft/kiota/issues/4761)
- Fix scalar member composed type serialization in PHP [#2827](https://github.com/microsoft/kiota/issues/2827)
- Trims unused components from output openApi document when generating plugins [#4672](https://github.com/microsoft/kiota/issues/4672)
- Fixes missing imports for UntypedNode when BackingStore is enabled in Java.
- Renames `name_to_be_defined` plugin type to `APIplugin` [#4713](https://github.com/microsoft/kiota/issues/4713)

## [1.14.0] - 2024-05-02

### Added

- Suppress CS1591 when generating CSharp code and documentation is not available
- Added file name suffix escaping in Go to avoid generating files with reserved suffixes. [#4407](https://github.com/microsoft/kiota/issues/4407)
- Added `KIOTA_OFFLINE_ENABLED` environment variable to disable checking for updates before each command. [#4556](https://github.com/microsoft/kiota/issues/4556)
- Added support for plugin auth options in the CLI. [#5072](https://github.com/microsoft/kiota/issues/5072)

### Changed

- Fixed a bug where the Microsoft Plugin Manifests would start with relative paths. [#4583](https://github.com/microsoft/kiota/issues/4583)
- Fixed a bug where TypeScript deserialization would fail on Uppercase properties.[#4479](https://github.com/microsoft/kiota/issues/4479)
- Fixed a bug where clients and plugins generation would leave empty log files. [#4584](https://github.com/microsoft/kiota/issues/4584)
- Changed URI template generation to reuse templates when required templates are absent across operations.
- Fixed path deduplication logic to avoid double `Id` suffixes in indexer names in scenarios where the `Id` suffix is already present.[#4519](https://github.com/microsoft/kiota/issues/4519)
- Updated reserved name providers for Java and Php so that "object" can be escaped.
- Fixes request builder disambiguation when child nodes had different prefixes for different paths with same parameters.[#4448](https://github.com/microsoft/kiota/issues/4448)
- Do not generate CS8603 warnings when enabling backing store in CSharp generation.
- Fixed excluding operation. [#4399](https://github.com/microsoft/kiota/issues/4399)
- Fixed a bug where absolute path would be used for workspace for local descriptions. [#4582](https://github.com/microsoft/kiota/issues/4582) [#4581](https://github.com/microsoft/kiota/issues/4581)
- Fixed plugin generation of `ApiManifest` type to not include the `x-ms-kiota-hash` in the generated plugin. [#4561](https://github.com/microsoft/kiota/issues/4561)

## [1.13.0] - 2024-04-04

### Added

- Added a warning message in the CLI when using preview languages. [#4316](https://github.com/microsoft/kiota/issues/4316)
- Added support for handling untyped Json content in C#,Golang, TypeScript and Java. [#2319](https://github.com/microsoft/kiota/issues/2319)
- Added TypeScript type check suppression to `.ts` files where unused imports cause build fail in projects which use `noUnusedLocals: true` compiler option. [#4397](https://github.com/microsoft/kiota/issues/4397)
- Fixed TypeScript generation bug when returning enums from endpoints. [#4426](https://github.com/microsoft/kiota/issues/4426)

### Changed

- Fixed Go generation bug when dealing with scalar collection body. [#4380](https://github.com/microsoft/kiota/issues/4380)
- Fixed a bug where multiple Visual Studio Code instances would make the extension install/update fail. [#3686](https://github.com/microsoft/kiota/issues/3686)
- Fixed a bug where models properties named "additionalData" or "BackingStore" would be ignored. [#4224](https://github.com/microsoft/kiota/issues/4224)
- PREVIEW: Renamed the config commands to workspace. [#4310](https://github.com/microsoft/kiota/issues/4310)
- PREVIEW: Moved preview configuration files to the .kiota directory. [#4310](https://github.com/microsoft/kiota/issues/4310)
- PREVIEW: Moved the copy descriptions to dedicated folders. [#4310](https://github.com/microsoft/kiota/issues/4310)
- PREVIEW: Renamed the config to workspace file. [#4310](https://github.com/microsoft/kiota/issues/4310)
- Fixed a bug where TypeScript generation would consider boolean argument as empty when false. [#4103](https://github.com/microsoft/kiota/issues/4103)
- Changed Csharp code generation to put braces on new lines (where it makes sense). [#4347](https://github.com/microsoft/kiota/issues/4347)
- Fixed a bug where some no-content status codes would be considered structured (301, 302, 303, 307) when described. [#4190](https://github.com/microsoft/kiota/issues/4190)
- TypeScript is now a preview language!

## [1.12.0] - 2024-03-06

### Added

- Added support for the new kiota config commands under a feature flag. [#3356](https://github.com/microsoft/kiota/issues/3356)
- Added the init command as part of the experience revamp of [#3356](https://github.com/microsoft/kiota/issues/3356)
- Added uri-form encoded serialization for Python. [#2075](https://github.com/microsoft/kiota/issues/2075)
- Added support for multipart form data request body in Python. [#3030](https://github.com/microsoft/kiota/issues/3030)
- Added support for Enums or collection of enum values as root of the payload. [#1042](https://github.com/microsoft/kiota-typescript/issues/1042)

### Changed

- BREAKING - Removed the async suffix from request adapter methods in TypeScript. [microsoft/kiota-typescript#992](https://github.com/microsoft/kiota-typescript/issues/992)
- Fixed mantis for bitwise enums in Go. [#3936](https://github.com/microsoft/kiota/issues/3936)
- Keyword in enum names for go should not be escaped. [#2877](https://github.com/microsoft/kiota/issues/2877)
- Generator method code reduction in Python. [#3695](https://github.com/microsoft/kiota/issues/3695)
- Fixed a bug with URI template generation for required parameters when they differ between operations. [#4148](https://github.com/microsoft/kiota/issues/4148)
- Fixed return doc comments for Go/Java/CSharp/TypeScript.
- Fixed type names in doc comments and deprecation noticed across languages.
- Added thrown exceptions in doc comments for Go/CSharp/Java/TypeScript. [#3811](https://github.com/microsoft/kiota/issues/3811)
- Fixed missing type/method names in deprecation comments.[#4186](https://github.com/microsoft/kiota/issues/4186)
- Fixed `cref` tags not closed in doc comments in CSharp generation.
- Deduplicates 4XX and 5XX error mappings when they map to the same type to reduce emitted code. [#4025](https://github.com/microsoft/kiota/issues/4025)
- 📢📢📢 Java generation is now stable! 🚀🚀🚀 special thanks to @andreaTP (Red Hat) for all the help.
- Fixed bug where stream responses would generate incorrect partial paging code. [#4207](https://github.com/microsoft/kiota/issues/4207)
- Sanitize Accept and Content-Type headers during generation. [#4211](https://github.com/microsoft/kiota/issues/4211)
- Fixed a bug in enum default value generator for TypeScript. [#4216](https://github.com/microsoft/kiota/issues/4216)
- Generate enum array for query parameters. [#4225](https://github.com/microsoft/kiota/issues/4225)

## [1.11.1] - 2024-02-05

### Added

### Changed

- Fixed a deadlock on update for multiple clients targeting the same local file.
- Fixed a deadlock when evicting cached descriptions.

## [1.11.0] - 2024-02-01

### Added

- Added 'none' key for serializer and deserializer arguments to enable portable clients generation. [#3796](https://github.com/microsoft/kiota/issues/3796)
- Added Japanese translations to vscode extension.
- Added support for deprecation annotations in Python. [#2798](https://github.com/microsoft/kiota/issues/2798)

### Changed

- Fixed serialization of scalar members in union types for Python. [#2828](https://github.com/microsoft/kiota/issues/2828)
- Fixed a bug where scalar error mappings would be generated even though it's not supported by the http request adapter. [#4018](https://github.com/microsoft/kiota/issues/4018)
- Switched to proxy generation for TypeScript, leading to about ~44% bundle sizes reduction. [#3642](https://github.com/microsoft/kiota/issues/3642)
- Required query parameters are now projected as `{baseurl+}foo/bar?required={required}` instead of `{baseurl+}foo/bar{?required}` so they are automatically populated if no value is provided. [#3989](https://github.com/microsoft/kiota/issues/3989)
- Fixed a bug where TypeScript models factory methods would be missing return types.
- Fixed a bug where generated paths would possibly get too long. [#3854](https://github.com/microsoft/kiota/issues/3854)
- The vscode extension now also displays the children nodes when filtering. [#3998](https://github.com/microsoft/kiota/issues/3998)

## [1.10.1] - 2024-01-12

### Added

### Changed

- Fixed an issue where domain expiration for apis.guru would lead to search failures.

## [1.10.0] - 2024-01-11

### Added

### Changed

- Java - Self-extraction of query parameters instead of using reflection. [#3965](https://github.com/microsoft/kiota/issues/3965)
- Fixed a bug where the discriminator validation rule would report false positives on nullable union types.
- Fixed a bug where constructors and model names where clashing in Go. [#3920](https://github.com/microsoft/kiota/issues/3920)
- Fixed a bug where the order of enum declaration might results in a missing enum type. [#3935](https://github.com/microsoft/kiota/issues/3935)
- Fixed java generating compound types with underscore in the name. [#3824](https://github.com/microsoft/kiota/issues/3824)
- Fixed syntax for ES/TS lint enable/disable.

## [1.9.1] - 2023-12-13

### Added

### Changed

- Fixed a regression introduced by [#3760](https://github.com/microsoft/kiota/issues/3760) in 1.9.0 and its previews where indexer parameter name would be wrong leading to invalid URLs. [#3901](https://github.com/microsoft/kiota/issues/3901)
- Fixed a bug in the vscode extension where the "Paste API Manifest" button would not be able to parse the manifest.
- Enhance the way Enums are expressed in Typescript. [#2105](https://github.com/microsoft/kiota/issues/2105)
- Fixed missing dependency version in info command. [#3894](https://github.com/microsoft/kiota/issues/3894)

## [1.9.0] - 2023-12-07

### Added

- Added `--content-type` option for requests with multiple allowed content types. (CLI)

### Changed

- Request builders are now in the index file to simplify imports and reduce generated code in TypeScript. [#3799](https://github.com/microsoft/kiota/issues/3799)
- Groups request builders and inline request/response bodies in the same file in TypeScript.
- Groups all reusable models in a single file in TypeScript. [#3843](https://github.com/microsoft/kiota/issues/3843)
- Fixed a bug where reserved name rename would not rename objects properly. [#3609](https://github.com/microsoft/kiota/issues/3609)
- Switched to a Jammy Chiseled base image for docker containers.
- Moved the withUrlMethod of TypeScript in the base package. [#3812](https://github.com/microsoft/kiota/issues/3812)
- Fixed a bug where path parameters deduplication would create collisions on sub path segments. [#3757](https://github.com/microsoft/kiota/issues/3757)
- Moved from net7 to net8.
- Removed windows OS from docker multi-platform image to align with [dotnet changes](https://github.com/dotnet/dotnet-docker/issues/4492).
- Fixed a bug where the emitted CSharp would not be compatible with netstandard2.0. [#3829](https://github.com/microsoft/kiota/issues/3829)
- Fixed a bug where import statements for additionalDataHolder and enumSet are missing when BackingStore is enabled in java. [#3643](https://github.com/microsoft/kiota/pull/3643)
- Fixed an issue where Kiota's regex's might time out. [#3797](https://github.com/microsoft/kiota/issues/3797)
- Fixed a bug where getBackingStore method body was malformed for java. [#3643](https://github.com/microsoft/kiota/pull/3643)
- Fixed a bug where serialize method will not write additional data when backingStore is enabled for java. [#3643](https://github.com/microsoft/kiota/pull/3643)
- Fixed a bug where paths with parameters in the same position but different names would make generation fail. [#3756](https://github.com/microsoft/kiota/issues/3756)
- Fixed a bug where a property named constructor would make generation fail. [#3756](https://github.com/microsoft/kiota/issues/3756)
- Removed reflection for Java enum deserialization. [microsoft/kiota-java#843](https://github.com/microsoft/kiota-java/pull/843)
- Added support for AnyOf arrays. [#3786](https://github.com/microsoft/kiota/pull/3792)
- Fixed a bug where property names that matched reserved type would be replaced in dotnet.
- Fixed pass by value for `contentType` param in Go `requestInfo.SetStreamContentAndContentType`[#3830](https://github.com/microsoft/kiota/issues/3830)
- Fixed parsing of `DateOnly` values generated in request executors [#3679](https://github.com/microsoft/kiota/issues/3679)
- Fixes generation of default values names for go constructor functions [#3436](https://github.com/microsoft/kiota/issues/3436)
- [Java] Removed the usage of reflection in `ApiClientBuilder` [`kiota-java#923`](https://github.com/microsoft/kiota-java/issues/923)
- Fixed a bug where path parameter type was not correctly detected during generation. [#3791](https://github.com/microsoft/kiota/issues/3791)

## [1.8.2] - 2023-11-08

### Added

### Changed

- Fixed generating any-type schemas [#3536](https://github.com/microsoft/kiota/issues/3536)
- Fixed float to string conversion with invariant culture.
- Fixed a bug where structured error mime types would not be filtered and prioritized through the configuration. [#3669](https://github.com/microsoft/kiota/issues/3669)
- Fixed a bug where vendor mime types would be ignored. [#3666](https://github.com/microsoft/kiota/issues/3666)
- Fixed a bug where additional parameter would be stripped from accept header. [#3667](https://github.com/microsoft/kiota/issues/3667), [#3667](https://github.com/microsoft/kiota/issues/3668)
- Generation for Java no longer utilizes Async api components. [Kiota-Java #175](https://github.com/microsoft/kiota-java/issues/175)

## [1.8.1] - 2023-11-02

### Added

### Changed

- Fixed a bug where query parameter enum reusable types would be trimmed. [#3637](https://github.com/microsoft/kiota/issues/3637)

## [1.8.0] - 2023-11-02

### Added

- 📢📢📢 Python generation is now stable! 🚀🚀🚀
- 📢📢📢 PHP generation is now stable! 🚀🚀🚀
- Added support for enum query parameter types. [#2490](https://github.com/microsoft/kiota/issues/2490)
- Added settings in the vscode extension for: backingStore, additionalData, excludeBackwardCompatible, cleanOutput, clearCache, serializers, deserializers, disabledValidationRules, structuredMimeTypes. [#3355](https://github.com/microsoft/kiota/issues/3355)
- Support for primary error message in PHP [#3276](https://github.com/microsoft/kiota/issues/3276)
- Added support for multiple content type request bodies. [#3377](https://github.com/microsoft/kiota/issues/3377)
- Added support for multiple content type responses. [#3377](https://github.com/microsoft/kiota/issues/3377)
- Support for primary error message in Python [#3277](https://github.com/microsoft/kiota/issues/3277)
- Added a json output for the `kiota info` command

### Changed

- Set serialization name for path parameters for use with url templating in Python. [#3612](https://github.com/microsoft/kiota/issues/3612)
- Include the type which a promise resolves to in PHPDocs for PHP. [#3542](https://github.com/microsoft/kiota/issues/3542)
- Added null check for null content type instances when getting deprecation information [#3588](https://github.com/microsoft/kiota/issues/3588)
- Aligns header management in Python with other languages. [#3430](https://github.com/microsoft/kiota/issues/3430)
- Fixed parameters that are in camelcase to snakecase in Python. [#3525](https://github.com/microsoft/kiota/issues/3525)
- Fixed missing imports for method parameters that are query parameters.
- Replaces the use of "new" by "override" and "virtual" in CSharp models.
- Fixed a bug where namespaces segment names might contain special characters. [#3599](https://github.com/microsoft/kiota/issues/3599)
- Fixed a bug in validation rules where form data would wrongfully warn for arrays. [#3569](https://github.com/microsoft/kiota/issues/3569)
- Fixed a bug where content type parameter would be missing for TypeScript, Java, PHP, Python, Ruby and Go. [#3610](https://github.com/microsoft/kiota/issues/3610)
- Fixed query parameters type mapping for arrays. [#3354](https://github.com/microsoft/kiota/issues/3354)
- The lock file now contains the relative path to the description in case of local path. [#3151](https://github.com/microsoft/kiota/issues/3151)
- Fixes a bug where query parameters would be missing in CSharp for ebc clients. [#3583](https://github.com/microsoft/kiota/issues/3583)
- Fixed bug where base64url and decimal types would not be generated properly in Java.
- Fixed a bug where object properties would not be serialized in TypeScript. [#3596](https://github.com/microsoft/kiota/issues/3596)
- Fixed bug where symbol name cleanup would not work on forward single quotes characters [#3426](https://github.com/microsoft/kiota/issues/3426).
- Fixed a bug where a "models" API path segment in the description would derail generation. [#3400](https://github.com/microsoft/kiota/issues/3400)
- Changes to the configuration of RequestInformation are preserved instead of being overwritten. [#3401](https://github.com/microsoft/kiota/pull/3401).
- Fix bug where import statements in typescript wasn't using import type notation for types that are erased at runtime. [#3190](https://github.com/microsoft/kiota/issues/3190)
- The structured content type generation parameter now supports prioritization with `q=value` syntax. [#3377](https://github.com/microsoft/kiota/issues/3377)
- Fixed bug where `Tilde` char convert to Enum member name properly in C#. [#3500](https://github.com/microsoft/kiota/issues/3500)
- Restore backing store feature for typescript. [#2613](https://github.com/microsoft/kiota/issues/2613)
- Fixed default code documentation for RequestBodyContentType method parameter.

## [1.7.0] - 2023-10-05

### Added

- Added support for tracing in Python. [#1872](https://github.com/microsoft/kiota/issues/1872)
- Added auto-generated comment for TypeScript generation. [#3244](https://github.com/microsoft/kiota/issues/3244)
- Added a new switch to exclude all assets generated only for backward compatibility. [#2952](https://github.com/microsoft/kiota/issues/2952)
- Added support for tracing (OpenTelemetry) in PHP. [#1871](https://github.com/microsoft/kiota/issues/1871)

### Changed

- Fixed class name casings when reference in the errorMappings in PHP.
- Removed `--json-no-indent` option in favor of `RAW_JSON` output format which does the same job. (CLI)
- Fixed imports for enum type properties with default values in Python. [#3367](https://github.com/microsoft/kiota/issues/3367)
- Updated constructor for request builders in Python to set passed path parameters. [#3352](https://github.com/microsoft/kiota/issues/3352)
- Fixed inherited type definition generation where some cases would not generate properly. [#2745](https://github.com/microsoft/kiota/issues/2745)
- Fixed naming convention for inline response types. [#2952](https://github.com/microsoft/kiota/issues/2952)
- Localhost based descriptions are not cached anymore to facilitate development workflows. [#3316](https://github.com/microsoft/kiota/issues/3316)
- Fixed a bug where the hints would miss quotes for paths and always use the API manifest. [#3342](https://github.com/microsoft/kiota/issues/3342)
- Fixed a bug where inline composed types for components schemas would have the wrong name. [#3067](https://github.com/microsoft/kiota/issues/3067)
- Fixed a bug where the casing of properties serialization name would be normalized. [kiota-serialization-json-dotnet#131](https://github.com/microsoft/kiota-serialization-json-dotnet/issues/131)
- Changed parameter order in with_url method body to match the signature of RequestBuilder constructor in Python. [#3328](https://github.com/microsoft/kiota/issues/3328)
- Removed redundant undefined qualifier in TypeScript for properties. [#3244](https://github.com/microsoft/kiota/issues/3244)
- The default status code response is now used as 4XX and 5XX when those class responses are not provided in the description. [#3245](https://github.com/microsoft/kiota/issues/3245)
- Adds codes files in typescript to reduce number of generated files. [#2116](https://github.com/microsoft/kiota/issues/2116)
- Fix null reference exception when a parameter is defined without a schema. (CLI).
- Log a message to stderr if a request is skipped due to missing data. (CLI) [#2210](https://github.com/microsoft/kiota/issues/2210)
- Fixes code file generation in typescript [#3419](https://github.com/microsoft/kiota/issues/3419)
- Writes fully qualified name of custom types when a type with a similar name exists in the class in PHP.
- Rename composed type wrapper when class already exists in the namespace. [#2964](https://github.com/microsoft/kiota/issues/2964)

## [1.6.1] - 2023-09-11

### Changed

- Hotfix release for pipeline failing because of Microsoft.OpenApi.ApiManifest preview dependency.

## [1.6.0] - 2023-09-11

### Added

- Added support for raw URL in the fluent API surface in CSharp, Go, Java, PHP, Python, Ruby, TypeScript. [#3199](https://github.com/microsoft/kiota/issues/3199)
- Added support for external documentation links within descriptions in Python. [#2041](https://github.com/microsoft/kiota/issues/2041)
- Added support for API manifests. [#3104](https://github.com/microsoft/kiota/issues/3104)
- Added support for reserved path parameters. [#2320](https://github.com/microsoft/kiota/issues/2320)
- Added support for csv enum values in enums using a mask in Go.
- Added support for `x-ms-enum-flags` extension in Generator to enable generation of bitwise(flagged) enum values[#3237](https://github.com/microsoft/kiota/issues/3237).
- Added support for mapping primary error messages in CSharp, Go, Java, and TypeScript. [#3066](https://github.com/microsoft/kiota/issues/3066)

### Changed

- Fixed an issue where dependencies would not show up for any other language than CSharp in the vscode extension. [#3226](https://github.com/microsoft/kiota/issues/3226)
- Multiple fixes to guarantee idempotency of subsequent runs. [#2442](https://github.com/microsoft/kiota/issues/2442)
- Fixed issue with generating classes with Aliases(PHP)[microsoftgraph/msgraph-beta-sdk-php#197](https://github.com/microsoftgraph/msgraph-beta-sdk-php/pull/197)
- Flattens the models namespaces in Ruby to avoid circular dependencies.
- Adds ObjectId as a reserved keyword in Ruby to have memory management issues.
- Replace Javax annotations in favor of Jakarta annotations for Java code generation. [#2810](https://github.com/microsoft/kiota/issues/2810)
- RequestExecuters call overload methods reducing code generation size for Java. [#3150](https://github.com/microsoft/kiota/issues/3150)
- Remove URISyntaxException from Java generated RequestExecutors and RequestGenerators. [#3149](https://github.com/microsoft/kiota/issues/3149)
- Adds 'Generated' annotation to generated Enums and Classes for Java. [#3106](https://github.com/microsoft/kiota/issues/3106)
- Fixes uuid conversion to string value in PathParameters in Go. [#3106](https://github.com/microsoft/kiota/issues/3176)
- Fixes a bug with incorrect reserved models renaming that occurs sometimes depending on the order of type processing [microsoftgraph/msgraph-sdk-dotnet/issues/2084](https://github.com/microsoftgraph/msgraph-sdk-dotnet/issues/2084)
- Work around a System.CommandLine bug where adjacent matching command names would crash the CLI parser (CLI). [microsoftgraph/msgraph-cli#316](https://github.com/microsoftgraph/msgraph-cli/issues/316) [microsoftgraph/msgraph-cli#320](https://github.com/microsoftgraph/msgraph-cli/issues/320), [dotnet/command-line-api#2260](https://github.com/dotnet/command-line-api/issues/2260)
- Aggregate typescript import statements by source [#3232](https://github.com/microsoft/kiota/issues/3232)
- Fixes a bug in dotnet where enums types would not be fully disambiguated when initialized in constructor with default values and existing conflicting property exists [#3233]
- Fixes a bug in generation of flagged enum properties and their serializer/deserializer functions in typescript [https://github.com/microsoft/kiota/issues/3260]
- Fixes missing EnumSet types in method parameter and return types in Java [https://github.com/microsoft/kiota/issues/3272]

## [1.5.1] - 2023-08-08

### Added

- Added backing store support for Python. [#2858](https://github.com/microsoft/kiota/issues/2858)
- Added support for indexer parameter description. [#2978](https://github.com/microsoft/kiota/issues/2978)

### Changed

- Renamed the Shell language to CLI. [#3023](https://github.com/microsoft/kiota/issues/3023)
- Fixed a bug where and extraneous indexer would be generated for CLI. [#3088](https://github.com/microsoft/kiota/issues/3088)
- Fixed a bug where type specific indexers would fail to build in Go. [#3090](https://github.com/microsoft/kiota/issues/3090)

## [1.5.0] - 2023-08-04

### Added

- Added the title of the API in the VSCode tree view. [#2779](https://github.com/microsoft/kiota/issues/2779)
- Added capability to serialize and deserialize UUIDs in typescript[#40](https://github.com/microsoft/kiota-typescript/issues/40)
- Added auto-generation header comment for class and enums in CSharp [#2886](https://github.com/microsoft/kiota/issues/2886)
- Added support for multipart form data request body in CSharp, Go, Java, and TypeScript. [#220](https://github.com/microsoft/kiota/issues/220)
- Added support for base64 encoded properties in TypeScript.
- Added support for type specific (non string) indexers parameters. [#2594](https://github.com/microsoft/kiota/issues/2594)

### Changed

- Fixed missing type comments in many cases. [#2868](https://github.com/microsoft/kiota/issues/2868)
- Fixed a bug where duplicate enum entries in the description would lead to duplicate members. [#2352](https://github.com/microsoft/kiota/issues/2352)
- Sunset app.kiota.dev in favour of the VSCode extension. [#2934](https://github.com/microsoft/kiota/issues/2934)
- Use schematized types for 206 response codes instead of binary. [#2880](https://github.com/microsoft/kiota/issues/2880)
- Type names are not changed to first char upper case in comments in some cases.
- Fixed a bug where the show command would display an upgrade warning.
- Updated `getEnumValues` method name to `getCollectionOfEnumValues` in TypeScript. [#2907](https://github.com/microsoft/kiota/pull/2907)
- Added `Method` to the list of `CSharpReservedClassNames`. [#2939](https://github.com/microsoft/kiota/pull/2939)
- Changed generation to use aggregate type for `TimeSpan` values in java [#2069](https://github.com/microsoft/kiota/issues/2069)
- Fixed generation of properties with identical names after symbol cleanup. [#2869](https://github.com/microsoft/kiota/issues/2869)
- Use `import type` syntax in Typescript for all code that will be erased from output at runtime. [#2959](https://github.com/microsoft/kiota/issues/2959)

## [1.4.0] - 2023-07-07

### Added

- Added support for Composed types (De)Serialization for Python Generation. [#1813](https://github.com/microsoft/kiota/issues/1813)
- Added support for deprecation annotations in C#, Java, TypeScript and Go. [#2605](https://github.com/microsoft/kiota/issues/2605)
- Added a message to update kiota when using an outdated version. [#2099](https://github.com/microsoft/kiota/issues/2099)

### Changed

- Fixed an issue with query parameter name normalization in Ruby and Python. [#2825](https://github.com/microsoft/kiota/issues/2825)
- Fixed serialization of scalar members in union types for C#, Go, Java. [#2462](https://github.com/microsoft/kiota/issues/2462)
- Fixes an issue where class to interface replacement in TypeScript would be flaky. [#2676](https://github.com/microsoft/kiota/issues/2676)
- Deprecated Visual Studio OpenAPI reference packages.
- Fixed a bug where TypeScript errors would loose inheritance to base error definition.
- Fixed a bug where types trimming would be too aggressive.
- Fixed a bug where base property detection would be broken resulting in duplicate properties in inheritance trees.
- Fixes a bug where classes ending up with Id would have the wrong names.
- Fixed a bug where default enum values would not fail to build in TypeScript. [#2615](https://github.com/microsoft/kiota/issues/2615)
- Replaced response handler parameter by request option to reduce generated code size in TypeScript. [#1855](https://github.com/microsoft/kiota/issues/1855)
- Fixed a bug where a stackoverflow exception occurs when inlined schemas have self-references [2656](https://github.com/microsoft/kiota/issues/2656)
- Fixed nil safety while type casting values in collections in Go
- Moved common RequestBuilder ((request_adapter, url_template and path_parameters)) and RequestConfiguration(headers, options) properties to respective base classes in Python.[2440](https://github.com/microsoft/kiota/issues/2440)
- Fixed a bug where escaped package names would not be lowercased in Java.
- Fix failing PHP integration tests [2378](https://github.com/microsoft/kiota/issues/2378)
- Prevents method overloading for go getters and setters with different values. [#2719](https://github.com/microsoft/kiota/issues/2719)
- Fixed PHP request executor methods that return enums.
- Allow configuration of the number of threads via the environment variable KIOTA_GENERATION_MAXDEGREEOFPARALLELISM.
- Fixes regression where enum options would be renamed in CSharp.
- Add locking to writing to log files.

## [1.3.0] - 2023-06-09

### Changed

- Changed python model classes to data classes. [#2684](https://github.com/microsoft/kiota/issues/2684)
- Fix issue with command conflicts causing CLI crashes. (Shell)
- Fix build error by splitting the ambiguous `--file` option into `--input-file` and `--output-file`. (Shell)
- Fixed including unused imports in Go [#2699](https://github.com/microsoft/kiota/pull/2410)
- Fixed a bug where error response type with primitive types would cause compile errors in dotnet [#2651](https://github.com/microsoft/kiota/issues/2693)
- Fixed a bug where CSharp generation would fail if the input openApi contained schemas named 'TimeOnly' or 'DateOnly' [2671](https://github.com/microsoft/kiota/issues/2671)
- Updated the reserved types for CSharp to include 'Stream' and 'Date' should be reserved names in CSharp [2369](https://github.com/microsoft/kiota/issues/2369)
- Fix issue with request builders with parameters being excluded from commands output. (Shell)
- Fixed a bug in setting default enum values fails if the symbol has been sanitized and the symbol only contains special characters [2360](https://github.com/microsoft/kiota/issues/2360)
- Fixed issue where duplicate query parameter names per path were added to the URL template. Now only distinct query parameter names are added. [2725](https://github.com/microsoft/kiota/issues/2725)

## [1.2.1] - 2023-05-16

### Changed

- Fixed a bug where Operation filters would be greedy and exclude non operation filters. [#2651](https://github.com/microsoft/kiota/issues/2651)
- Shorten Go File names to a max of 252
- Fixed a bug where clean output option would fail because of the log file. [#2645](https://github.com/microsoft/kiota/issues/2645)
- Fixed a bug in the extension where selection in multiple indexers would fail. [#2666](https://github.com/microsoft/kiota/issues/2666)

## [1.2.0] - 2023-05-04

### Added

- 📢📢📢 Go is now a stable language!
- Added typescript interfaces for models and request config params. [#1013](https://github.com/microsoft/kiota/issues/1013) and [#1521](https://github.com/microsoft/kiota/issues/1521)
- Added automatic loading of the lock file for the extension so quick edits of clients are supported.
- Added a warning message when clients get upgraded from one kiota version to another. [#2598](https://github.com/microsoft/kiota/issues/2598)
- Added trimming of derived types that are not being used by the client. [#2543](https://github.com/microsoft/kiota/issues/2543)
- Added support for merging schemas of AllOf > 2. [#2438](https://github.com/microsoft/kiota/issues/2438)
- Added operation selection in the vscode extension. [#2556](https://github.com/microsoft/kiota/issues/2556)
- Added Chinese translations to vscode extension.
- Added an action to open documentation in the vscode extension. [#2562](https://github.com/microsoft/kiota/issues/2562)

### Changed

- Fixed issue where implements for error classes were not copied when inlining classes.
- Moved the common properties to a base class and remove properties(RequestAdapter, UrlTemplate and PathParameters) for the request builders and options and headers for RequestConfig classes PHP.[2439](https://github.com/microsoft/kiota/issues/2439)
- Fixed bugs with imports for PHP Generation.
- Indexers replacement are now at the same level as the original indexer. e.g `client.userById("id").messagesById("id")...` is now `client.users.withId("id").messages.withId("id")...`.
- Fixed a bug where arrays with empty items definitions would still project properties. [#2502](https://github.com/microsoft/kiota/issues/2502)
- Fixed a bug where multiple single path parameters at the same level would produce invalid url templates.
- Fixed a bug where steps count would be increasing on nav back in the extension. [#2553](https://github.com/microsoft/kiota/issues/2553)
- Fixed a bug where java path parameters wouldn't build.
- Fixed a bug where extension would not reset generation information on new search. [#2540](https://github.com/microsoft/kiota/issues/2540)
- Fixed a bug where the extension would not select nodes when loading from lock file with no filters. [#2542](https://github.com/microsoft/kiota/issues/2542)
- Fixed a bug where the extension would fail to generate for the root path. [#2536](https://github.com/microsoft/kiota/issues/2536)
- Fixed a bug where properties copied from parent to child classes would not be cloned.
- Fixed a bug where Java discriminator mapping would use the mapping name instead of the type name.
- Fixed a bug where filters for nodes with same-level single path parameters with different names would not work anymore.
- Fixed a bug where replacing reserved names would not propagate the rename to the inner child elements map of the parent class.
- Fixed a bug where descriptions with multiple server URLs would use the HTTP one instead of HTTPs. [#2336](https://github.com/microsoft/kiota/issues/2336)
- Fixed a bug where backing store properties would be sometimes duplicated in derived classes.
- Write PHP URL templates in request builders using single quoted strings to prevent need to escape $-prefixed names e.g. $count, $ref, $value.

## [1.1.3] - 2023-04-18

### Changed

- Fixed a bug where certain configuration sections would not load properly.

## [1.1.2] - 2023-04-17

### Changed

- Fixed Mac-OS releases.

## [1.1.1] - 2023-04-05

### Changed

- Fixed a bug where kiota installation would fail because of zip structure change.

## [1.1.0] - 2023-04-05

### Added

- Added Visual Studio Code preview extension. [#2333](https://github.com/microsoft/kiota/issues/2333)
- Added support for searching in forks for API descriptions in GitHub. [#2429](https://github.com/microsoft/kiota/issues/2429)
- Added the ability to filter on operations. [#2431](https://github.com/microsoft/kiota/issues/2431)

### Changed

- Fixed a bug where UUID type is not correctly passed to deserialization method due to snake casing of primitive type names.
- Fixed a bug where unescaped query parameters are not correctly matched to the original name due to python convention of snake casing parameter names.
- Fixed a bug where date types annotations and guid's were not correctly translated in Python
- Fixed the extension of downloaded files when using the default path. [#2316](https://github.com/microsoft/kiota/issues/2316)
- Fixed a bug where lookup of reference ids failed for AllOf more than one level up.
- Fixed a bug where a CLI client would not set the content types for requests. (Shell)
- Fixed linting errors by re-ordering methods and properties in Python.
- Fixed a bug where requests with bodies would fail in Ruby. [#2473](https://github.com/microsoft/kiota/issues/2473)
- Changed python import mechanism to facilitate code completion. [#2380](https://github.com/microsoft/kiota/issues/2380)
- Fixed a bug where discriminator methods were missing possible types in Python [#2381](https://github.com/microsoft/kiota/issues/2381)
- Fixed a bug where boolean or number enums would be mapped to enums instead of primitive types. [#2367](https://github.com/microsoft/kiota/issues/2367)
- Fixed a bug where CSharp inherited constructor name was incorrect. [#2351](https://github.com/microsoft/kiota/issues/2351)
- Fixed a bug where java refiner would emit method's parameters types without normalizing the name.
- Fixed a bug where java refiner would emit incorrect returning types and error mappings without normalizing the name.
- Changed the name of the static query parameter factory method from `addQueryParameters` to `createQueryParameters` in PHP
- Fixed a bug where java writer would emit incorrect serialization values for escaped enums
- Fixed a bug where java writer would emit incorrect type names in case of compound types
- Fixed a bug where go refiner would emit incorrect code when inlining error parents
- Fixed a bug where inline type names would not be sanitized. [#2368](https://github.com/microsoft/kiota/issues/2368)
- Fixed a bug in PHP where the base URL path parameter key didn't match the URI template.
- Changed invalid schema behavior, invalid properties are now ignored with a warning instead of failed. [#2089](https://github.com/microsoft/kiota/issues/2089)
- Fixed a bug where java refiner would not normalize inherited class names and interface types.
- Fixed a bug where search based commands would not match exact matches when additional results are available.
- Fixed a bug where imported classes and enums would not be disambiguated when they have the same name in dotnet.
- Fixed a bug where escaping enum names resulted in a loss of the original enum name. [#2488](https://github.com/microsoft/kiota/issues/2488)
- Fixed a bug where properties names are not correctly normalized in Go.

## [1.0.1] - 2023-03-11

- Fixed a bug where double would not be mapped properly.

## [1.0.0] - 2023-03-10

- 📢📢📢 Kiota is Generally Available with C# as a first stable language and more to follow soon! 🚀🚀🚀

### Added

- Added constructors and query parameter factory methods to request configuration classes and constructors to query parameter classes in PHP.
- Added support for relative server URL. [#2278](https://github.com/microsoft/kiota/issues/2278)
- Added restoration of the kiota-lock when the generation fails with clean output. [#2292](https://github.com/microsoft/kiota/issues/2292)

### Changed

- Fixed a bug where byte and binary types would be wrongly mapped. [#2357](https://github.com/microsoft/kiota/issues/2357)
- Fixed a bug where go refiner would fail with a null reference.
- Fixes a bug where request builders would be incorrectly generated due to inconsistent suffix generation
- Fixed a bug where PHP model getAdditionalData() would not return nullable types.
- Fixed bug in request options PHPDoc type.
- Fixed a bug where java refiner would emit enums without normalizing the name.
- Fixed bug in request configuration class constructor PHPDoc.
- Fixed a bug where ruby refiner would emit enums without normalizing the name.

## [0.11.1] - 2023-02-13

### Added

- Added support for multi-valued headers in Python. [#2051](https://github.com/microsoft/kiota/issues/2051)
- Added `getResponseStatusCode` to PHP exceptions reserved names provider. [#2243](https://github.com/microsoft/kiota/issues/2243)

### Changed

- Fixed a bug where search would fail because of a parsing issue. [#2290](https://github.com/microsoft/kiota/issues/2290)
- Fixed a bug where Ruby namespaces would fail to load with Rails.
- Fixed a bug where errors/exceptions could override native exception type symbols in Python. [#2257](https://github.com/microsoft/kiota/issues/2257)
- Fixed a bug where descriptions with a path segment matching an HTTP verb would fail to generate. [#2231](https://github.com/microsoft/kiota/issues/2231)

## [0.11.0] - 2023-02-07

### Added

- Updated the client constructor to set the base_url in path parameters from RequestAdapter's base_url(Python) [#2128](https://github.com/microsoft/kiota/issues/2128)
- Added support for Raw Url in Request Builders for PHP Generation. [2205](https://github.com/microsoft/kiota/issues/2205)
- Added support for external documentation links on request execution methods (PHP Generation). [2038](https://github.com/microsoft/kiota/issues/2038)
- Added support for nullable reference types in dotnet for projects running Netstandard 2.1/Net 6.0 and above [2073](https://github.com/microsoft/kiota/issues/2073)
- Added support for multi-value headers to CLI generation. (Shell)
- Added support for overriding some of the generation settings in the OpenAPI description. [#2197](https://github.com/microsoft/kiota/issues/2197)
- Added support for multi-value headers for PHP Generation. [#2052](https://github.com/microsoft/kiota/issues/2052)
- Added support for Composed types (De)Serialization for PHP Generation. [#1814](https://github.com/microsoft/kiota/issues/1814)
- Added support for backing store in Go. [466](https://github.com/microsoft/kiota/issues/466)
- Added support for inherited error types by inlining the parents. [2194](https://github.com/microsoft/kiota/issues/2194)
- Added support for documentation links in CLI's help commands.

### Changed

- Fixed bug in indexer methods for PHP Generation.
- Fixed a bug where errors/exceptions could override native exception type symbols for PHP Generation. [#2258](https://github.com/microsoft/kiota/issues/2258)
- Fixed a bug where most of the Java fields have been prefixed with an underscore.
- Mangle properties and/or accessors names per language to have more idiomatic APIs.
- Using fully qualified identifier for java.util.function.Consumer to avoid conflicts in Java.
- Removed response handler parameter from PHP request executor methods. [1856](https://github.com/microsoft/kiota/issues/1856)
- Fixed minor typo in adding Accept header for PHP.
- Fixed a bug with null reference types and composed types in CSharp.
- Fixed a bug with null reference types scalar values in CSharp.
- Fixed a bug where reserved names replacement wouldn't check whether the name was already in use (all languages).
- Fixed a bug where default OpenAPI.net validation rules could not be disabled.
- Fixed a race condition in namespace disambiguation for CSharp.
- Fixed a bug where errors/exceptions could override native exception type symbols. [#2190](https://github.com/microsoft/kiota/issues/2190)
- Removed the ResponseHandler parameter in RequestAdapter to be a RequestOption in Python [#1857](https://github.com/microsoft/kiota/issues/1857)
- Updated the client constructor to set the baseUrl path parameter from RequestAdapter's baseUrl(PHP) [#2129](https://github.com/microsoft/kiota/issues/2129)
- The Lock file uses a project version coming from a Source Generator instead of the one looked up with reflection. [#2147](https://github.com/microsoft/kiota/issues/2147)
- Fixed a bug in ruby where file names or paths could be too long to be packaged.
- Fixed a bug where models descriptions would be non-deterministic. [#2130](https://github.com/microsoft/kiota/issues/2130)
- Fixed a bug in dotnet where default values for Enum properties with special characters would not match the model. [#2091](https://github.com/microsoft/kiota/issues/2091)
- Sets the base url to make use of request information easier in CSharp/Java/TypeScript/Go/Ruby. [#2061](https://github.com/microsoft/kiota/issues/2061)
- Renamed CreateXXXRequestInformation methods to ToXXXRequestInformation for a better auto-completion experience. [#2071](https://github.com/microsoft/kiota/issues/2071)
- Renamed Go request adapter methods to remove the async suffix. [#2084](https://github.com/microsoft/kiota/issues/2084)
- Fixed a bug where CLI query/header/path parameters would not be deduplicated. [#2059](https://github.com/microsoft/kiota/issues/2059)
- Removed unused generated import for PHP Generation.
- Fixed a bug where long namespaces would make Ruby packaging fail.
- Fixed a bug where classes with namespace names are generated outside namespace in Python. [#2188](https://github.com/microsoft/kiota/issues/2188)
- Changed signature of escaped reserved names from {x}*escaped to {x}* in line with Python style guides.
- Add null checks in generated Shell language code.
- Fixed a bug where Go indexers would fail to pass the index parameter.
- Fixed a bug where path segments with parameters could be missing words. [#2209](https://github.com/microsoft/kiota/issues/2209)
- Fixed a bug where refiners could generate duplicate properties.
- Fixed a bug where Go collections would try to use variadic parameters where not supported.
- Removed the need to provide a RequestAdapter in Shell command builders.

## [0.10.0] - 2023-01-04

### Added

- Added support for auto-registration of serializers in Ruby. [#478](https://github.com/microsoft/kiota/issues/478)
- Added support for middleware infrastructure in Ruby. [#1650](https://github.com/microsoft/kiota/issues/1650)
- Added support for query parameters names aliasing in Ruby. [#1664](https://github.com/microsoft/kiota/issues/1664)
- Added support for vendor specific serialization in Ruby. [#1661](https://github.com/microsoft/kiota/issues/1661)
- Added support for default properties values in Ruby. [#1725](https://github.com/microsoft/kiota/issues/1725)
- Added support for discriminated types deserialization (inheritance) in Ruby. [#1652](https://github.com/microsoft/kiota/issues/1652)
- Added support for error mapping in Ruby. [#1653](https://github.com/microsoft/kiota/issues/1653)
- Added support for multi-valued request headers in Ruby. [#2054](https://github.com/microsoft/kiota/issues/2054)
- Added support for composed types generation in Ruby.
- Added missing get child node method in Ruby for deserialization.
- Added declaration of module classes in Ruby.

### Changed

- Fixed container support for MacOS M1. [#1888](https://github.com/microsoft/kiota/issues/1888)
- Fixed a bug where a missing baseURL would make search fail. [#2095](https://github.com/microsoft/kiota/issues/2095)
- Fixed a bug in Ruby where the request adapter URL would be overwritten by the client defaults. [#1647](https://github.com/microsoft/kiota/issues/1647)
- Replaced concurrent-ruby by Fibers in Ruby libraries to implement proper asynchronous execution of requests.
- Replaced response_handler parameter by a request option in Ruby. [#1860](https://github.com/microsoft/kiota/issues/1860)
- Fixed a bug where conversion of intersection types to wrappers would fail.
- Fixed raw url initialization in Ruby.
- Fixed a bug where subsequent indexers would fail to convert properly for languages not supporting indexers. [#1666](https://github.com/microsoft/kiota/issues/1666)
- Fixed a bug where the ISO duration import would be incorrect in Ruby.
- Fixed a bug where default middleware options would not be assigned in Ruby.
- Fixed a bug where request options would not be mapped properly in Ruby.
- Fixed a bug where the main module would be missing in Ruby and TypeScript.
- Fixed a bug where class names could conflict with module names in Ruby.
- Fixed a bug where modules listing would be not be deterministic in Ruby and TypeScript.
- Moved Ruby libraries to their own repositories.
- Fixed a regression where errors would be missing their parent types.
- Fixed a regression where indexers replacement would fail.

## [0.9.0] - 2022-12-19

### Added

- Added description validation rules to help users get the best client experience. [#2019](https://github.com/microsoft/kiota/issues/2019)
- Added support for external documentation links on request execution methods. [#2036](https://github.com/microsoft/kiota/issues/2036)
- Added support for multi-valued headers in CSharp, TypeScript, Go, and Java. [#2032](https://github.com/microsoft/kiota/issues/2032)

### Changed

- Fixed a generation issue in TypeScript where static methods imports could collide.
- Fixed a generation issue in Go with the accept headers definition.
- Fixed a generation issue in Go and TypeScript with UUID properties.
- Fixed issue with wrong imports for PHP. [#2049](https://github.com/microsoft/kiota/pull/2049)
- Fix issue where discriminator types were never getting imported for PHP. [#2049](https://github.com/microsoft/kiota/pull/2049)
- Fix issue where class aliasing was never working as expected for PHP. [#2049](https://github.com/microsoft/kiota/pull/2049)
- Fixed colliding imports for factory methods in TypeScript. [#2009](https://github.com/microsoft/kiota/issues/2009)
- Switched to lazy loading module imports in Python. [#2007](https://github.com/microsoft/kiota/issues/2007)
- Caters for type names being used from System namespace in CSharp generation [#2021](https://github.com/microsoft/kiota/issues/2021)
- Fixed wrong send request method name for collections in Python. [#2057](https://github.com/microsoft/kiota/issues/2057)
- Implemented request builders with no parameters as properties in Python. [#2024](https://github.com/microsoft/kiota/issues/2024)

## [0.8.3] - 2022-12-01

### Changed

- Unblocks nuget release by removing file triggering credscan.

## [0.8.2] - 2022-12-01

### Changed

- Unblocks nuget release by removing file triggering credscan.

## [0.8.1] - 2022-12-01

### Changed

- Fixes publishing workflow missing workload restore commands.

## [0.8.0] - 2022-12-01

### Added

- Added support for GitHub based API search.[#1866](https://github.com/microsoft/kiota/issues/1866)
- Added login/logout commands to access API descriptions in private GitHub repositories. [#1983](https://github.com/microsoft/kiota/issues/1983)
- Added support for scalar request bodies Python [#1571](https://github.com/microsoft/kiota/issues/1571)
- Sets property defaults in constructor and removes duplicate properties defined in base types from model serialization and deserialization methods in Python. [#1726](https://github.com/microsoft/kiota/issues/1726)
- Added support for scalar request bodies in PHP [#1937](https://github.com/microsoft/kiota/pull/1937)
- Added accept header for all schematized requests Python. [#1617](https://github.com/microsoft/kiota/issues/1617)
- Added optional backing store support for PHP. [#1976](https://github.com/microsoft/kiota/pull/1976)
- Fixed a bug where ODataErrors had wrong inherited class name in Python.
- Fixed a bug where empty path parameters dictionary would throw an error in request builders in Python.

### Changed

- Fixed a bug where readonly properties would fail to deserialize for TypeScript.
- Fixed a bug where array buffers nullability would wrongly be defined for TypeScript.
- Fixed a bug where parameter comments would appear in summary tag comments in dotnet. [#1945](https://github.com/microsoft/kiota/issues/1945)
- Fixed a bug in PHP generation where request bodies would not serialize single elements properly. [#1937](https://github.com/microsoft/kiota/pull/1937)
- Fixed a bug where request information would always be set from scalar. [#1965](https://github.com/microsoft/kiota/pull/1965)
- Fixed a bug where path parameters would be missing if no operation was present at the segment the parameter is defined. [#1940](https://github.com/microsoft/kiota/issues/1940)
- Fixed a bug where nested classes with long names caused compilation errors for java generated libraries. [#1949](https://github.com/microsoft/kiota/issues/1949)
- Removed use of anonymous classes in java generated libraries to reduce the number of java classes created at compilation time. [#1980](https://github.com/microsoft/kiota/pull/1980)
- Fixed a bug where generation would result in wrong indentation in some classes for Python [#1996](https://github.com/microsoft/kiota/issues/1996).
- Fixed a bug where error class modules were hardcoded for Python [#1999](https://github.com/microsoft/kiota/issues/1999)
- Fixed a bug where generation would sometimes result in wrong original names for query parameters in Python [#2000](https://github.com/microsoft/kiota/issues/2000).
- Fixed a bug where Java would fail to compile for endpoints that return collections.

## [0.7.1] - 2022-11-01

### Changed

- Fixes publishing workflow which fails because of the web application.

## [0.7.0] - 2022-11-01

### Added

- Added an API key authentication provider for dotnet, TypeScript, Go and Java. [#1902](https://github.com/microsoft/kiota/issues/1902)
- Added compatibility all the way down to android API level 26 for Java.
- Added support for enum and collection of enum return types for Java.
- Added support for types with more than 500 discriminator entries in Java.
- Added a confirmation message once the generation is successful. [#1898](https://github.com/microsoft/kiota/issues/1898)
- Added color scheme for all console messages to improve readability. [#1895](https://github.com/microsoft/kiota/issues/1895)

### Changed

- Fixed a bug where collections request bodies would not serialize single elements properly. [#1927](https://github.com/microsoft/kiota/issues/1927)
- Removed response handler parameter from Java executor methods.
- Changed the generated PHP deserializer code to use `fn` instead of `function`. [#1880](https://github.com/microsoft/kiota/pull/1880)
- Fixes compile errors due to type ambiguity in generated models in dotnet. [#1881](https://github.com/microsoft/kiota/issues/1881)
- Changes the ResponseHandler parameter in IRequestAdapter to be a RequestOption in dotnet [#1858](https://github.com/microsoft/kiota/issues/1858)
- File extensions are now stripped from property/namespace/class names. [#1892](https://github.com/microsoft/kiota/issues/1892)
- Missing host/server is now considered a warning instead of a critical error. [#1896](https://github.com/microsoft/kiota/issues/1896)
- Fixed a bug where info and show commands would crash in case of invalid description URL. [#1894](https://github.com/microsoft/kiota/issues/1894)
- Show command now reads descriptions directly from APIs.guru instead of their origin. [#1897](https://github.com/microsoft/kiota/issues/1897)
- Fixed a classnames having the same name as extensions would cause generation to fail. [#1892](https://github.com/microsoft/kiota/issues/1892)
- Fixed an issue where CSharp defensive programming would use string.IsNullOrEmpty for collections parameters.

## [0.6.0] - 2022-10-06

### Added

- Added a search command to find APIs.
- Added a download command to download API descriptions.
- Added a show command to display the API paths as a tree.
- Added an info command to show languages maturity and dependencies.
- Added hints to help people use and discover the commands.
- Added arguments to filter path items during generation (include-path/exclude-path).
- Added the ability to cancel the refinement process.
- Added Java 8 generation support.
- Added tracing support for Go. [#618](https://github.com/microsoft/kiota/issues/618)

### Changed

- BREAKING: the generation command is now a sub command: `kiota generate ...` instead of `kiota ...`.
- BREAKING: docker image renamed from `mcr.microsoft.com/kiota/generator` to `mcr.microsoft.com/openapi/kiota`.
- Fixed a bug where OData primitive types would result in composed types.
- Fixed a concurrency issue with imports management.
- Fixed a bug where Java request options type could conflict with generated types.
- Fixed a bug where CSharp serialization/deserialization names for properties would always be lowercased. [#1830](https://github.com/microsoft/kiota/issues/1830)
- Fixed a regression where the incorrect schema would be selected in an AllOf collection to generate incorrect type inheritance.
- Fixed a bug where discriminator information could contain non-derived types. [#1833](https://github.com/microsoft/kiota/issues/1833)
- Fixes a bug where mapping value would be missing from factories. [#1833](https://github.com/microsoft/kiota/issues/1833)
- Update go serializers and deserializers to use abstractions utils

## [0.5.1] - 2022-09-09

### Added

- Exempts read only properties from being serialized and sent to the service. [#1828](https://github.com/microsoft/kiota/issues/1828)

### Changed

- Fixed a regression where parse node parameter type for factories would be incorrect in Go, Ruby, Swift, Java and TypeScript.

## [0.5.0] - 2022-09-08

### Added

- Added support for range (2XX) responses. [#1699](https://github.com/microsoft/kiota/issues/1699)
- Added none output formatter to CLI commons. (Shell)
- Added 'Accept' field of http request header in Ruby. [#1660](https://github.com/microsoft/kiota/issues/1660)
- Added support for text serialization in Python. [#1406](https://github.com/microsoft/kiota/issues/1406)
- Added support for composed types (union, intersection) in CSharp, Java and Go. [#1411](https://github.com/microsoft/kiota/issues/1411)
- Added support for implicit discriminator mapping.
- Added support for default values of enum properties in CSharp, Java and Go.

### Changed

- Fixed a bug where Go clients would panic in case of nil response value.
- Fixed a bug to properly add request headers to NetHttp requests in Ruby.
- Fixed a bug to properly reject invalid URLs in Ruby.
- Fixed an issue with require statements being generated instead of require relative in Ruby.
- Updated AdditionDataHolder with the correct namespace. (Ruby)
- Removed/fixed passing in the current instance to fields deserializers in Ruby. [#1663](https://github.com/microsoft/kiota/issues/1663)
- Fix issue with duplicate variable declaration in command handlers (Shell)
- Update namespace qualification algorithm (helps in resolving when a type name appears in multiple namespaces) to use case insensitive string comparison (CSharp).
- Fix an issue where namespace reserved name replacement would not include replacing import names in the declared areas in CSharp. [#1799](https://github.com/microsoft/kiota/issues/1799)
- Removed Python abstractions, http, authentication and serialization packages
- Fixed an issue with generating the incorrect serialized type name and require statement for get/post methods (Ruby).
- Remove all overloads for GO request executors
- Adds a context object in all GO requests
- Remove all overloads for GO request executors and Adds a context object in all GO requests [GO#176](https://github.com/microsoftgraph/msgraph-sdk-go/issues/176)
- Fixed a bug where the Hashing method for type names differentiation could lock the process.
- Fixed a bug where CSharp declaration writer would add usings for inner classes.
- Fixed a bug with inline schema class naming.
- Fixed a bug where symbols starting with a number would be invalid.
- Fixed a bug where classes could end up with duplicated methods.
- Fixed a bug where Go writer would try to import multiple times the same symbol.
- Fixed a bug where the core generator engine would fail to recognize meaningful schemas.
- Fixed a bug where Go and Java inner class imports would be missing.
- Fixed a bug where Go and Java collection bodies would not generate properly.
- Aligns request options types in Java with other collections type.
- Fixed a bug where Java would skip duplicated imports instead of deduplicating them.
- Fixed a bug where Java would not convert date types for query parameters.
- Fixed a bug where Java doc comments could contain invalid characters.
- Fixed a bug where function parameters would be reordered incorrectly in dotnet[#1822](https://github.com/microsoft/kiota/issues/1822)

## [0.4.0] - 2022-08-18

### Added

- Updated test suite and tooling for python abstractions and core packages. [#1761](https://github.com/microsoft/kiota/issues/367)
- Added support for no-content responses in python abstractions and http packages. [#1630](https://github.com/microsoft/kiota/issues/1459)
- Added support for vendor-specific content types in python. [#1631](https://github.com/microsoft/kiota/issues/1463)
- Simplified field deserializers for json in Python. [#1632](https://github.com/microsoft/kiota/issues/1492)
- Adds python code generation support. [#1200](https://github.com/microsoft/kiota/issues/163)
- Added native type support for Duration, Time Only, and Date Only in Ruby. [#1644](https://github.com/microsoft/kiota/issues/1644)
- Added a `--additional-data` argument to generate the AdditionalData properties [#1772](https://github.com/microsoft/kiota/issues/1772)
- Added CAE infrastructure in Ruby by adding an `--additional-properties` parameter to the authenticate method of AuthenticationProvider, the get access token method of the AccessTokenProvider in Ruby. [#1643](https://github.com/microsoft/kiota/issues/1643)
- Added Kiota authentication library for Ruby. [#421](https://github.com/microsoft/kiota/issues/421)

### Changed

- Fixed a bug where collections types would generate invalid return types in CSharp.
- Fixed a bug where a nullable entry in anyOf schemas would create unnecessary composed types.
- Removed duplicate properties defined in base types from model serialization and deserialization methods and initialize property defaults in constructor. [#1737](https://github.com/microsoft/kiota/pull/1737)
- Fixed a bug where the generated code had incorrect casing within a method (Ruby). [#1672](https://github.com/microsoft/kiota/issues/1672)
- Fixed an issue where duplicate 'require' statements are generated for inner classes in the middle of the file (Ruby). [#1649](https://github.com/microsoft/kiota/issues/1649)
- Split parsable interface and additional property/data interface in Ruby. [#1654](https://github.com/microsoft/kiota/issues/1654)
- Changed format of datetime in Go to be converted to ISO 8601 by default when place in path parameters(Go)
- Defined the Access Token Provider Interface for Ruby authentication. [#1638](https://github.com/microsoft/kiota/issues/1638)
- Reduce code verbosity on Go Getters and Setters. [G0#26](https://github.com/microsoftgraph/msgraph-sdk-go-core/issues/26)

## [0.3.0] - 2022-07-08

### Added

- Added a more explicit error message for invalid schemas. [#1718](https://github.com/microsoft/kiota/issues/1718)
- Added a parameter to specify why mime types to evaluate for models. [#134](https://github.com/microsoft/kiota/issues/134)
- Added an explicit error message for external references in the schema. [#1580](https://github.com/microsoft/kiota/issues/1580)
- Added accept header for all schematized requests. [#1607](https://github.com/microsoft/kiota/issues/1607)
- Added support for paging. [#1569](https://github.com/microsoft/kiota/issues/1569)
- Added support for vendor specific content types(PHP) [#1464](https://github.com/microsoft/kiota/issues/1464)
- Added support for accept request header (PHP) [#1616](https://github.com/microsoft/kiota/issues/1616)
- Added Getting Started steps for PHP. [#1642](https://github.com/microsoft/kiota/pull/1642)
- Defined the Access Token Provider interface (Ruby) [#1638](https://github.com/microsoft/kiota/issues/1638)
- Added Continuous Access Evaluation infrastructure (Ruby) [#1643](https://github.com/microsoft/kiota/issues/1643)

### Changed

- Fixed a bug where query parameter types would not consider the format. [#1721](https://github.com/microsoft/kiota/issues/1721)
- Fixed a bug where discriminator mappings across namespaces could create circular dependencies in Go. [#1712](https://github.com/microsoft/kiota/issues/1712)
- Fixed a bug where Go binary downloads would try to parse a structured object.
- Aligned mime types model generation behavior for request bodies on response content. [#134](https://github.com/microsoft/kiota/issues/134)
- Fixed an issue where some critical errors would not return a failed exit code. [#1605](https://github.com/microsoft/kiota/issues/1605)
- Moved nested request configuration classes into separate files within the namespace for PHP. [#1620](https://github.com/microsoft/kiota/pull/1620)
- Fixed an issue where duplicate 'require' statements are generated for inner classes in the middle of the file (Ruby). [#1649](https://github.com/microsoft/kiota/issues/1649)
- Fixed wrong parameter type for Request config for request executors(PHP). [#1629](https://github.com/microsoft/kiota/pull/1629)
- Increased indentation for errorMappings in the request executor (PHP). [#1629](https://github.com/microsoft/kiota/pull/1629)
- Fixed bugs in PHP discriminator factory methods, Guzzle request adapter send methods, stream and plain text response handling. [#1634](https://github.com/microsoft/kiota/pull/1634)
- Removed abstractions, authentication, http and serialization packages for PHP. [#1637](https://github.com/microsoft/kiota/pull/1637)
- Fixed a bug where generated discriminator methods would reference types in other namespaces without proper resolution. [#1670](https://github.com/microsoft/kiota/issues/1670)
- Fixed a bug where additional data and backing store properties would be duplicated. [#1671](https://github.com/microsoft/kiota/issues/1671)
- Fixed a bug where serialized properties would not match the json property name when using the backing store. (CSharp).
- Corrected PHPDoc types for headers and request options properties in request configuration classes. [#1711](https://github.com/microsoft/kiota/pull/1711)
- Fixed a bug where properties defined at multiple inherited models would collide. [#1717](https://github.com/microsoft/kiota/issues/1717)

## [0.2.1] - 2022-05-30

### Added

- Added missing mappings in PHP for uint8 and int8. [#1473](https://github.com/microsoft/kiota/pull/1473)
- Added support for enum and enum collections responses in Go. [#1578](https://github.com/microsoft/kiota/issues/1578)
- Added Kiota builder engine as a package for external services integration. [#1582](https://github.com/microsoft/kiota/issues/1582)

### Changed

- Fixed a bug where the logger would not log all the information. [#1588](https://github.com/microsoft/kiota/issues/1588)

## [0.2.0] - 2022-05-24

### Added

- Added support for enum options descriptions (C#/Go/Java/TypeScript). [#90](https://github.com/microsoft/kiota/issues/90)
- Added support for file parameters types. [#221](https://github.com/microsoft/kiota/issues/221)
- Added support for no content responses in PHP. [#1458](https://github.com/microsoft/kiota/issues/1458)
- Added support for error handling in php request adapter. [#1157](https://github.com/microsoft/kiota/issues/1157)
- Added support for discriminator downcast in PHP. [#1255](https://github.com/microsoft/kiota/issues/1255)
- Added support for multiple collections indexing under the same parent.
- Added code exclusions placeholder in the generation. (oneOf)
- Added support for continuous access evaluation in Java. [#1179](https://github.com/microsoft/kiota/issues/1179)
- Added support for special characters in URL query parameter names. [#1584](https://github.com/microsoft/kiota/pull/1584)

### Changed

- Fixed a bug where union types would not work as error types.
- Fixed a bug where generation names could collide with platform names in CSharp.
- Fixed missing numbers mapping cases.
- Fixed multiple bugs enum options invalid symbols generation.
- Fixed a bug where symbols (classes, enums, properties...) could be only numbers, which is unsupported by most languages.
- Fixed a bug where union types would be missing serialization information.
- Fixed a bug where inline request bodies could override each other for the same path item with multiple operations.
- Fixed simple collections (arrays) support in CSharp.
- Fixed a bug where code properties could not be union or exclusion types.
- Fixed a bug where models would fail to generate if the schema type wasn't set to object.
- Fixed a bug where nullable wrapper schema flattening would ignore some composed type options.
- Fixed a bug where arrays without items definition would derail generation.
- Fixed a bug with enums detection for generation. (interpreted as string)
- Fixed a bug where classes names cleanup could end-up in a collision.
- Fixed a bug where null reference exception would be thrown when trying to lookup type inheritance on discriminators
- Fixed the lookup of model namespaces to only look in the target namespace to avoid reference collisions.
- Fixed a bug for the generated send method for paths returning Enums in dotnet.
- Breaking: renamed the --loglevel parameter to --log-level.
- Fixed a bug where some path parameter objects would have empty key values [#1586](https://github.com/microsoft/kiota/issues/1586)

## [0.1.3] - 2022-05-06

### Added

- Added text serialization library for PHP. [#1546](https://github.com/microsoft/kiota/pull/1546).

### Changed

- Fixed the image name in CI for MCR.

### Changed

## [0.1.2] - 2022-05-06

### Changed

- Minor changes in the parameters (-co => --co, -ll => --ll, -d is required, -l is required).

## [0.1.1] - 2022-05-06

### Changed

- Add binder for nullable boolean options. (Shell)

## [0.1.0] - 2022-05-04

### Added

- The dotnet tool is now available on the public feed `dotnet tool install -g Microsoft.OpenApi.Kiota --prerelease`.
- The dotnet OpenApi reference package is now available `Microsoft.OpenApi.Kiota.ApiDescription.Client`.
- The container image is now available on mcr. `docker pull mcr.microsoft.com/kiota/generator:latest`.

### Changed

- Revamped the api surface for request configuration. [#1494](https://github.com/microsoft/kiota/issues/1494)
- Fixed a bug in methods naming in Go after request configuration revamp.
- Fixes a bug where reserved names would not be updated for inheritance.
- Add `item` subcommand for indexers. Fixes conflicts when paths have repeating segments. (Shell) [#1541](https://github.com/microsoft/kiota/issues/1541)

## [0.0.23] - 2022-04-19

### Changed

- Fixed a bug where line returns in descriptions could break the generated code. [#1504](https://github.com/microsoft/kiota/issues/1504)
- Fixed a bug with special characters in query parameters names. [#1445](https://github.com/microsoft/kiota/issues/1445)
- Fixed a bug where complex types path parameters would fail to generate.
- Fixed a bug where Go serialization/deserialization method would generate invalid accessor names.
- Added discriminator support in the python abstractions serialization and http packages. [#1500](https://github.com/microsoft/kiota/issues/1256)

## [0.0.22] - 2022-04-08

### Added

- Added generation of command options for headers defined in the OpenAPI metadata source file. (Shell)
- Added retry, redirect, chaos and telemetry handler in java.

### Changed

- Simplified field deserialization.(PHP) [#1493](https://github.com/microsoft/kiota/issues/1493)
- Fixed a bug where the generator would not strip the common namespace component id for models. [#1483](https://github.com/microsoft/kiota/issues/1483)
- Simplified field deserialization. [#1490](https://github.com/microsoft/kiota/issues/1490)

## [0.0.21] - 2022-04-01

### Added

- Added text output formatter to CLI commons. (Shell)
- Added support for vendor specific content types generation/serialization. [#1197](https://github.com/microsoft/kiota/issues/1197)
- Added support for 204 no content in generation and CSharp/Java/Go/TypeScript request adapters. #1410
- Added a draft swift generation implementation. #1444
- Added support for yaml response type generation. [#302](https://github.com/microsoft/kiota/issues/302)
- Added support for xml response type generation. [#302](https://github.com/microsoft/kiota/issues/302)
- Added support for unstructured response generation (stream). [#546](https://github.com/microsoft/kiota/issues/546)

### Changed

- Moved go libraries to their own repository. [#370](https://github.com/microsoft/kiota/issues/370)
- Fixed a bug where the base url of the request adapter would be reset by the client(PHP). [#1469](https://github.com/microsoft/kiota/issues/1469)
- Fixed issue where custom date types are never corrected for method parameters(PHP). #1474
- Replaced DateTimeOffset with DateTime for custom date types(PHP). #1474
- Fixed a bug where the base url of the request adapter would be reset by the client. [#1443](https://github.com/microsoft/kiota/issues/1443)
- Fixed a bug where request builder classes for collections endpoints would have a wrong name. #1052
- Fixed issue with ambiguous type names causing build errors and stack overflows. (Shell) #1052
- Fixed a bug where symbols (properties, methods, classes) could contain invalid characters #1436
- Renamed parameters for requests: o => options, q => queryParameters, h => headers. [#1380](https://github.com/microsoft/kiota/issues/1380)
- Fixed a bug where names would clash with reserved type [#1437](https://github.com/microsoft/kiota/issues/1437)
- Fixed unnecessary use of fully qualified type names in Dotnet.

## [0.0.20] - 2022-03-25

### Changed

- Moved TypeScript middleware from Graph core to kiota http.
- Fixed a bug where errors would fail to deserialize for TypeScript.
- Fixed a bug where decimal types would not be mapped in TypeScript.
- Fixed circular dependencies issues for TypeScript #870.
- Fixed a bug where JSON serialization would fail on nil properties in Go.
- Moved typescript core packages into Kiota-TypeScript repo and delete for Kiota repo.
- Fixed a bug where collections of complex types could be mis-represented. [#1438](https://github.com/microsoft/kiota/issues/1438)
- Fixed a bug where inline properties would not generate their own type definition. [#1438](https://github.com/microsoft/kiota/issues/1438)

## [0.0.19] - 2022-03-18

### Added

- Adds a `--clean-output` argument to clean the target directory before generation #1357
- Adds support for `text/plain` responses for CSharp, Java, TypeScript and Go. #878

### Changed

- Fixed a bug where models descriptions would not be deterministic #1393
- Fixed a bug where unnecessary namespaces would be added to models generation #1273
- Fixed a bug where Go byte arrays would not write deserializers properly.
- Fixed a bug where integers would not be recognized when type is not number.
- Fixed a bug where union types with primitive member types would fail to generate #1270
- Fixed a bug where union types with inline schema member types would fail to generate #1270
- Fixed a bug where referenced types with no titles would fail to generate #1271
- Fixed a bug where the generator would introduce unnecessary union types for nullables. #990
- Moved all the dotnet libraries to their own repository. #1409

## [0.0.18] - 2022-03-14

### Added

- Added default implementations for table and JSON output in CLI commons (Shell) #1326
- Adds missing mapped types (int8, uint8, commonmark, html, ...) #1287

### Changed

- Add missing method getBinaryContent to the ParseNode interface(PHP).
- Split the Parsable interface into AdditionalData interface and Parsable interface(PHP) #1324.
- Shell commands will now default to writing indented JSON. This option can be disabled through the CLI option `--json-no-indent` (Shell) #1326
- Update System.CommandLine version (Shell) #1338
- Add async writers in output formatters (Shell) #1326
- Add async filter function in output filters (Shell) #1326
- BREAKING: Remove synchronous version of WriteOutput that accepts a stream input (Shell) #1326
- BREAKING: Remove synchronous version of WriteOutput that accepts a string input (Shell) #1326
- BREAKING: Remove synchronous version of FilterOutput that accepts a string input (Shell) #1326
- Fixed a bug where error responses without schema would make generation fail #1272
- Fixed non-deterministic parameters ordering #1358
- Fixed non-deterministic error mappings ordering #1358
- Fixed non-deterministic discriminator mapping ordering #1358
- Fixed race condition when removing child items leading to erratic code generation results #1358
- Replaced models namespaces flattening by circular properties trimming in Go #1358
- Fixed a bug where inherited interfaces would be missing imports in Go #1358
- Fixed a bug where inherited interfaces would be missing imports for the parent #1358
- Fixed bugs across request adapter and serialization in PHP #1353
- Fixed NullReferenceException in Go generator
- Fixed incorrect mapping when the response type is `text/plain` #1356
- Fixed a bug in Dotnet.Typescript where properties could have invalid characters #1354
- Improved error display #1269
- Fixed a bug where union wrapper models would lack the discriminator methods.
- Fixed bug working with async azure credentials in Python.
- Fixed minor issues around PHP Generation, Serialization and Abstractions.
- Fix Discriminator support for PHP.
- Move additional data from Parsable into AdditionalDataHolder base class in Python #1360

## [0.0.17] - 2022-03-03

### Added

- Adds support for downcast of types during deserialization according to the discriminator information in the description (CSharp/Go/Java/TypeScript). [#646](https://github.com/microsoft/kiota/issues/646)
- Adds support for generating interfaces for models in Go. [#646](https://github.com/microsoft/kiota/issues/646)
- Adds support for generating functions (as opposed to methods or static methods) in the generator (used in TypeScript for discriminator factories). [#646](https://github.com/microsoft/kiota/issues/646)
- Added support for global error handling in python abstractions #1289
- Added a HTTPRequestAdapter for python Requests library #1251
- Added Shell output filter (JMESPath) support #1291
- Added output options to Shell output filter #1321

### Changed

- Fixed a bug in Go generator where temporary url template parameters would not be used preventing the use of raw urls.
- Fixed a bug where the Go http client configuration would impact non-kiota requests.
- Fixed bug where installing python abstractions failed due to missing dependencies #1289
- Modified python test matrix to include python 3.10 #1289
- Added return statement to AnonymousAuthenticationProvider in python abstractions #1289
- Fixed bug in enabling backing store for parse node factory by passing ParseNodeFactoryRegistry to method call #1289
- Fixed errors in python serialization due to to responses as json instead of json strings #1290
- Added python version 3.10 to testing matrix #1290
- Fixed bug with inconsistent Java namespace and directory name casing #1267
- Fixed typeOf string check in JsonParseNode Typescript.
- Fixed shell stream output getting processed by output formatters when no file path is provided #1291
- Using Record type instead of Map for additionalData in TypeScript

## [0.0.16] - 2022-02-23

### Added

- Added the ability to configure the underlying transport in Go. #1003
- Added additional date time (date, time, duration) types in the generation process. #1017
- PHP Request Adapter (includes middleware) #1048, #918, #1024, #1025
- Added support for PHP Json Serialization.
- Adds Python abstractions library. #925
- Adds hostname and protocol validation in authentication. #1051
- Adds Azure Identity Authentication Provider for Python. #1108
- Adds JSON Serialization library for Python. #1186
- Adds PHP League Authentication Provider for PHP #1201
- Added Shell language support #738

### Changed

- Fixed a bug where request body would get dropped by the compression handler in Go
- Fixed an issue where multiple api clients could run into racing conditions in Go.
- Fixed a bug where empty additional data in Go would lead to invalid JSON payloads during serialization.
- Fixed a bug where Go serialization would write empty arrays for nil values.
- Modified the TypeScript RequestInformation URL parameter data type from URL to string.
- Modified TypeScript packages to provide CJS and ESM modules.
- Modified the TypeScript RequestInformation query and path parameters data type from Map to Record Type.
- Modified TypeScript RequestInformation headers and options to Record type.
- Modified the TypeScript RequestInformation content data type to ArrayBuffer.
- Updated PHP abstractions to make property keys and values nullable in `SerializationWriter.php`.
- Fixed an issue where enum collections parsing would fail in Go.
- Breaking. Kiota clients generate error types and throw when the target API returns a failed response (dotnet, go, java, typescript). #1100
- Fixed missing methods for serializing/deserializing decimal values in dotnet #1252
- Modified RequestBuilder types are suffixed with the ItemRequestBuilder if they belong to an item namespace to fix name collisions #1252
- Modified the use of fully qualified name of types in dotnet to ensure the target type and current element are not in the same namespace #1252.

## [0.0.15] - 2021-12-17

### Changed

- Fixes name collisions in dotnet by renaming "HttpMethod" enum to "Method" in dotnet abstractions
- Add support for PHP Generation.
- Migrated generator to dotnet 6 #815
- Fixes a bug where json deserialization would fail in go
- Fixes a bug where query parameters would not be added to the request in go
- Fixes a bug where at signs in path would derail generation
- Fixes Go doc comments in packages and generation
- Fixes a bug where RequestInformation did not accept some content headers in dotnet
- Added support for providing cancellation token in dotnet #874, #875, #876
- Upgrades go libraries to go17.
- Fixes a bug in Go where reserved keywords for properties would be wrongly replaced.
- Fixes a bug in Go where setters would be missing nil checks.
- Fixes a bug where OData select query parameter would not be normalized
- Fixes a bug in Go where empty collections would not be serialized.
- Fixes a bug where generation would fail because of empty usings.
- Fixes a bug where Java and Go escaped model properties would not serialize properly.
- Fixes a bug where null values would not be added to additionalData if there was no matching property in dotnet.
- Fixes a bug where deserialization of enums would throw an ArgumentException if the member didn't exist in dotnet.

## [0.0.14] - 2021-11-08

### Added

- Added support for changing the base url #795

### Changed

- Fixes a bug where arrays of enums could be wrongly mapped.
- Fixes a bug where go deserialization would fail on collections of scalars.
- Fixes a bug where TypeScript query parameters would be added to headers instead #812
- Update dotnet abstractions and core libraries to target netstandard2.1 from net5.0

## [0.0.13] - 2021-10-27

### Changed

- Technical release to bump version number of go packages after replace removal

## [0.0.12] - 2021-10-27

### Added

- Adds Go authentication, http and serialization libraries and finalizes the generation #716

## [0.0.11] - 2021-10-27

### Changed

- Switched to URL templates instead of string contract for URL building #683
- Fixed a bug where CSharp method names would not follow naming conventions #730

## [0.0.10] - 2021-10-06

### Changed

- Renames MiddlewareOption into RequestOption to stay agnostic from implementation #635
- Aligned http packages on naming convention #444

## [0.0.9] - 2021-10-01

### Added

- Adds support for path parameters #573
- Adds missing type mappings in TypeScript #573
- Adds a missing http core method for collections of primitives #573
- Aliases imports with the same name in typescript #573

### Changed

- Fixes a bug where empty title would make generation fail #558
- Fixes a bug where float, long and binary types would not be parsed by the generator #558
- Fixes a bug where generation would fail on compact namespace names #558
- Renames request info into request information to avoid conflicts with platform #559
- Fixes a bug where the server url would not be taken in consideration #626
- Fixes a bug where missing namespaces would make the generation fail #573
- Fixes a bug where class names could contain special characters #573
- Fixes a bug where namespace names could contain path parameters #573
- Fixes a bug where namespace names could contain special characters #573
- Multiple performance improvements #573
- Fixes a bug where path generation would deduplicate segments leading to the wrong path #573
- Fixes a bug where the CodeDOM would be corrupted (bad tree) leading to incoherent generation results #573
- Fixes a bug where the generator would duplicate some models #573
- Moves the models to a dedicated namespace (models) #573
- Fixes a bug where enum serialization would be calling the wrong method in TypeScript #573
- Fixes a bug where request body would use the response schema #573
- Fixes an issue where type could conflict with namespace names and prevent CSharp compilation #573
- Fixes an issue where primitive types would map to the wrong serialization method in dotnet #573
- Fixes an issue where union models would not be able to deserialize because of missing members #573
- Fixes an issue where request builder methods would refer to non-existent properties in dotnet #573
- Fixes an issue where duplicated symbols for different imports would make java compilation fail #573
- Adds missing type mappings in java #573
- Fixes an issue where Go generation could use reserved keywords #573
- Fixes a bug where Go generation could end up with circular dependencies in models #573
- Fixes a bug where Go generation would map the wrong http core method for primitive types #573
- Fixes a bug where Go generation would have unused imports making build fail #573
- Fixes a bug where missing type definitions would make Ruby generation fail #573
- Fixes a bug where Go generation would miss the module symbol for inherited constructors #573

## [0.0.8] - 2021-08-25

### Added

- Ruby JSON serialization #429
- Ruby HTTP service #472
- Go generation support & abstractions #413

### Changed

- Fixed a bug where raw collections requests would not be supported #467
- Fixes a bug where in memory backing store would not return changed properties to null #243
- Fixes a bug where generated models would be tied to a specific backing store implementation #400
- Fixed #428 a bug where inline double definition would make code dom generation fail
- Revamped authentication provider interface to allow multiple authentication schemes #498
- Fixed a bug preventing from using request builders with raw URls #508

## [0.0.7] - 2021-08-04

### Added

- Ruby generation implemented #244
- Adds middleware support for http clients #330

## [0.0.6] - 2021-07-26

### Added

- Initial ruby abstractions #212
- Backing store support #223
- Doc comments for abstractions libraries #324

### Changed

- Better client configuration #268
- Request builders constructors for data validation #322

## [0.0.5] - 2021-06-10

### Changed

- Expands code coverage to 88% #147
- Removes json assumption for request body to support multiple formats #170
- Escapes language reserved keywords #184
- Replaces custom URL tree node by class provided by OpenAPI.net #179
- Splits the core libraries in 3 separate libraries #197
- Changes default namespace and class name to api client #199
- Aligns Parsable interfaces across languages #204
- Fixes a bug where classes with properties of identical name would make build fail in CSharp #222

### Added

- Adds kiota packaging as a dotnet tool #169
- Adds input parameters validation #168
- Adds support for collections as root responses #191

## [0.0.4] - 2021-04-28

### Changed

- Multiple performance improvements for large descriptions
- Deterministic ordering of properties/methods/indexers/subclasses
- Deterministic import of sub path request builders
- Stopped generating phantom indexer methods for TypeScript and Java
- Fixed a bug where prefixed properties would be missing their prefix for serialization

## [0.0.3] - 2021-04-25

### Added

- Adds supports for additional properties in models

## [0.0.2] - 2021-04-20

### Added

- CI/CD to docker image (private feed) and GitHub releases #112, #115
- Documentation to get started
- Published the core packages #110
- Factories support for serializers and deserializers #100
- Documentation comment generation #92
- Submodule with generation samples #106
- Test coverage information in sonarcloud #78

### Changed

- Fixed a bug where date time offset properties would not be generated properly #116
- Fixed a bug where generating from http/https OpenAPI description would fail #109
- Fixed a bug where simple schema references would not be handled #109
- Removed a dependency on operation id #89
- Fixed a bug where the sonarcloud workflow would fail on external PRs #102
- Fixed a bug where empty class names would fail the generation #88

## [0.0.1] - 2021-04-20

### Added

- Initial GitHub release

