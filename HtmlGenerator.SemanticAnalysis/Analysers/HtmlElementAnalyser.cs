namespace HtmlGenerator.SemanticAnalysis.Analysers
{
    public class HtmlElementAnalyser
    {
        public static bool IsValid(HtmlElement element)
        {
            ElementInformation elementInformation = Sema.GetElementInformation(element.Tag);
            if (elementInformation == null)
            {
                // No such element
                return false;
            }
            if (elementInformation.IsVoid != element.IsVoid)
            {
                // A non-void element was void or vice versa
                return false;
            }/*
            if (!elementInformation.AttributesAnalyser.IsValid(element))
            {
                // Invalid attributes
                return false;
            }
            if (!elementInformation.ElementsAnalyser.IsValid(element))
            {
                // Invalid elements
                return false;
            }*/

            return true;
        }
    }
}
