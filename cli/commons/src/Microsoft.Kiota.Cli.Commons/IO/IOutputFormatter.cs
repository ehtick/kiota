﻿namespace Microsoft.Kiota.Cli.Commons.IO;

/// <summary>
/// Output formatter contract.
/// </summary>
public interface IOutputFormatter
{
    /// <summary>
    /// Format and write string content
    /// </summary>
    /// <param name="content">The string content to format and write out</param>
    void WriteOutput(string content);

    /// <summary>
    /// Format and write stream content
    /// </summary>
    /// <param name="content">The stream content to format and write out</param>
    void WriteOutput(Stream content);
}
