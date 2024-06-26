using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using PlaylistConverter.Utilities;

namespace PlaylistConverter.Converters
{
    public class XmlPlaylistConverter
    {
        public void ConvertPlaylistToText(string inputPlaylistPath, string outputTextPath)
        {
            var doc = XDocument.Load(inputPlaylistPath);
            var uniqueTestNames = new HashSet<string>();
            var extractor = new DisplayNameExtractor();

            foreach (var property in doc.Descendants("Property")
                                    .Where(e => e.Attribute("Name")?.Value == "TestWithNormalizedFullyQualifiedName"))
            {
                string testName = property.Attribute("Value")?.Value;
                if (testName == null)
                {
                    Console.WriteLine("Test name is null");
                    continue;
                }

                var displayNames = extractor.ExtractDisplayNames(property);

                foreach (var displayName in displayNames)
                {
                    var uniqueTestName = $"{testName}({displayName})";
                    if (!uniqueTestNames.Contains(uniqueTestName))
                    {
                        Console.WriteLine($"{uniqueTestName}");
                        uniqueTestNames.Add(uniqueTestName);
                    }
                }
            }

            if (uniqueTestNames.Count == 0)
            {
                Console.WriteLine("No tests found.");
            }
            else
            {
                File.WriteAllLines(outputTextPath, uniqueTestNames);
                Console.WriteLine($"Wrote {uniqueTestNames.Count} tests to {outputTextPath}");
            }
        }
    }
}
