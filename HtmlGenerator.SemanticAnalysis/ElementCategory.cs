using System;

namespace HtmlGenerator.SemanticAnalysis
{
    [Flags]
    public enum ElementCategory
    {
        None = 0,
        Metadata = 1,
        Interactive = 2,
        Heading = 4,
        Palpable = 8,
        Phrasing = 16,
        Flow = 32,
        Embedded = 64,
        SectioningRoot = 128,
        Listed = 256,
        Labelable = 512,
        Submittable = 1024,
        FormAssociated = 2048,
        ScriptSupporting = 4096,
        Text = 8192,
        Sectioning = 16384,
        Resettable = 32768
    }
}
