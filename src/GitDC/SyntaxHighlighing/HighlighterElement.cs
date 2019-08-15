using System.Collections.Generic;

namespace GitDC.SyntaxHighlighing
{
    public class HighlighterElement
    {
        public string Value { get; set; }
        public Dictionary<string, string> Attributes { get; set; }

        public HighlighterElement(string value, IDictionary<string, string> attributes)
        {
            Value = value;
            Attributes = new Dictionary<string, string>(attributes);
        }
    }
}
