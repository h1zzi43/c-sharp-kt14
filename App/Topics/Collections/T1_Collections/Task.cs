using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace App.Topics.Collections.T1_Collections;

public static class CollectionsTasks
{
    public static ArrayList FilterUniqueStringsNonGeneric(IEnumerable source)
    {
        if (source == null)
            return new ArrayList();

        var uniqueStrings = source
            .OfType<string>() 
            .Select(s => s.Trim()) 
            .Where(s => !string.IsNullOrEmpty(s)) 
            .Distinct(StringComparer.OrdinalIgnoreCase) 
            .ToList();

        return new ArrayList(uniqueStrings);
    }

    public static List<string> FilterUniqueStringsGeneric(IEnumerable<string> source)
    {
        if (source == null)
            return new List<string>();

        return source
            .Where(s => s != null) 
            .Select(s => s.Trim()) 
            .Where(s => !string.IsNullOrEmpty(s)) 
            .Distinct(StringComparer.OrdinalIgnoreCase) 
            .ToList();
    }
}
