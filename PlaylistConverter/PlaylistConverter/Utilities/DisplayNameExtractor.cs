using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace PlaylistConverter.Utilities
{
    public class DisplayNameExtractor
    {
        public IEnumerable<string> ExtractDisplayNames(XElement property)
        {
            return property.Parent.Elements("Rule")
                             .Where(rule => rule.Descendants("Property")
                                          .Any(p => p.Attribute("Name")?.Value == "DisplayName"))
                             .SelectMany(rule => rule.Descendants("Property")
                                               .Where(p => p.Attribute("Name")?.Value == "DisplayName")
                                               .Select(p => ExtractValueBetweenParentheses(p.Attribute("Value")?.Value)))
                             .Where(displayName => displayName != null);
        }

        private string ExtractValueBetweenParentheses(string input)
        {
            string pattern = @"\(([^)]*)\)";
            Match match = Regex.Match(input, pattern);
            return match.Success ? match.Groups[1].Value : null;
        }
    }
}
