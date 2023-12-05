using System.Text.RegularExpressions;
public static class Logic {
    public static int PartOne(string line) {
        var coll = Regex.Matches(line, @"(\d)");    
        return int.Parse($"{coll.First().Value}{coll.Last().Value}");
    }

    public static int PartTwo(string line) {
        var dict = new Dictionary<string, string> 
        {
            {"one", "1"}, {"two", "2"}, {"three", "3"},
            {"four", "4"}, {"five", "5"}, {"six", "6"},
            {"seven", "7"}, {"eight", "8"}, {"nine", "9"}
        };

        var first = Regex.Match(line, @"(\d|one|two|three|four|five|six|seven|eight|nine)");
        var last = Regex.Match(line, @"(\d|one|two|three|four|five|six|seven|eight|nine)", RegexOptions.RightToLeft);

        var firstInt = dict.ContainsKey(first.Value) ? dict[first.Value] : first.Value;
        var lastInt = dict.ContainsKey(last.Value) ? dict[last.Value] : last.Value;

        return int.Parse($"{firstInt}{lastInt}");
    }
}