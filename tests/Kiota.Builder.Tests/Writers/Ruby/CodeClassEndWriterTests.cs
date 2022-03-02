using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Xunit;

namespace Kiota.Builder.Writers.Ruby.Tests {
    public class CodeClassEndWriterTests: IDisposable {
        private const string DefaultPath = "./";
        private const string DefaultName = "name";
        private readonly StringWriter tw;
        private readonly LanguageWriter writer;
        private readonly CodeBlockEndWriter codeElementWriter;
        private readonly CodeClass parentClass;
        public CodeClassEndWriterTests() {
            codeElementWriter = new CodeBlockEndWriter(new RubyConventionService());
            writer = LanguageWriter.GetLanguageWriter(GenerationLanguage.Ruby, DefaultPath, DefaultName);
            tw = new StringWriter();
            writer.SetTextWriter(tw);
            var root = CodeNamespace.InitRootNamespace();
            parentClass = new CodeClass {
                Name = "parentClass"
            };
            var main = root.AddNamespace("main");
            main.AddClass(parentClass);
        }
        public void Dispose() {
            tw?.Dispose();
            GC.SuppressFinalize(this);
        }
        [Fact]
        public void ClosesNestedClasses() {
            var child = parentClass.AddInnerClass(new CodeClass {
                Name = "child"
            }).First();
            codeElementWriter.WriteCodeElement(child.EndBlock as BlockEnd, writer);
            var result = tw.ToString();
            Assert.Single(Regex.Matches(result, ".*end.*"));
        }
        [Fact]
        public void ClosesNonNestedClasses() {
            codeElementWriter.WriteCodeElement(parentClass.EndBlock as BlockEnd, writer);
            var result = tw.ToString();
            Assert.Equal(2, Regex.Matches(result, ".*end.*").Count);
        }
    }
}
