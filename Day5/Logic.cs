using System.Text.RegularExpressions;

public static class Logic {

    public static void SortMappings(ref int i, ref string[] arr, List<MappingStruct> list, string loopUntilContains) {
        while(!arr[i++].Equals(loopUntilContains) && i < arr.Length) {
            var map = Regex.Matches(arr[i], @"(\d+)");

            if (map.Count > 0) {
                list.Add(new MappingStruct {
                    Destination = Int64.Parse(map[0].Value),
                    Source = Int64.Parse(map[1].Value),
                    Range = Int64.Parse(map[2].Value)
                });
            }
        }
    }

    public static List<long> PartOne(List<long> sources, List<MappingStruct> destinations) {
        var list = new List<long>();
        
        foreach(var source in sources) {
            var finalDest = source;

            foreach(var dest in destinations) {
                if (source >= dest.Source && source <= dest.Source+dest.Range) {
                    finalDest = source + (dest.Destination-dest.Source);
                    break;
                }
            }
            
            list.Add(finalDest);
        }
        
        return list;
    }

    public static List<long> PartTwo(List<long> sources) {
        return new List<long>();
    }
}

public struct MappingStruct {
    public long Source {get;set;}
    public long Destination {get;set;}
    public long Range {get;set;}
}