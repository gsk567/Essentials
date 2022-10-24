using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Newtonsoft.Json;

namespace Essentials.Helpers.Slugify
{
    public static class SlugifyResourcesHelper
    {
        public static void BuildCharmapDictionary(string filePath)
        {
            var charmapJson = File.ReadAllText(Path.Combine("Slugify", "charmap.json"));
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(charmapJson);

            var template = new SlugifyCharmap();
            template.Session = new Dictionary<string, object>
            {
                { "Data", dictionary },
            };

            var fileContent = template.TransformText();
            File.WriteAllText(filePath, fileContent);
        }
    }
}