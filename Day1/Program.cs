using System.Text.RegularExpressions;

var dict = new Dictionary<string, int> 
{
    {"one", 1}, 
    {"two", 2},
    {"three", 3},
    {"four", 4},
    {"five", 5},
    {"six", 6 },
    {"seven", 7},
    {"eight", 8 },
    {"nine", 9 }
};

var arr = File.ReadAllLines("TestDate.txt");
var total = 0;

foreach (var line in arr)
{
    var first = Regex.Match(line, @"(\d|one|two|three|four|five|six|seven|eight|nine)");
    var last = Regex.Match(line, @"(\d|one|two|three|four|five|six|seven|eight|nine)", RegexOptions.RightToLeft);

    var firstInt = dict.ContainsKey(first.Value) ? dict[first.Value] : int.Parse(first.Value);
    var lastInt = dict.ContainsKey(last.Value) ? dict[last.Value] : int.Parse(last.Value);

    var finalNo = int.Parse($"{firstInt}{lastInt}");
    total += finalNo;    
}

Console.WriteLine(total);
