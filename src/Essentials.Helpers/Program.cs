using System;
using System.IO;
using Essentials.Helpers.Slugify;

SlugifyResourcesHelper.BuildCharmapDictionary(
    Path.Combine(
        Environment.CurrentDirectory,
        "..",
        "..",
        "..",
        "..",
        "Essentials",
        "Internals",
        "SlugifyCharmap.cs")
    );