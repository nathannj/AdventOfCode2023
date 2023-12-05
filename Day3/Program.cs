using System.Text.RegularExpressions;

var arr = File.ReadAllLines("TestData.txt");
var partOneTotal = 0;
var partTwoTotal = 0;

var numberList  = new LinkedList<List<Match>>();
var symbolList  = new LinkedList<List<Match>>();

foreach (var line in arr)
{
    var numberMatches = Regex.Matches(line, @"(\d+)");
    var symbolMatches = Regex.Matches(line, @"([^.\d])");
    numberList.AddFirst(numberMatches.ToList());
    symbolList.AddFirst(symbolMatches.ToList());
    var symbols = symbolList.SelectMany(e => e.Select(f => f.Index));

    partOneTotal += Logic.PartOne(numberList, symbolList);
    partTwoTotal += Logic.PartTwo(numberList, symbolList);

    if (numberList.Count > 2 && symbolList.Count > 2) {
        numberList.RemoveLast();
        symbolList.RemoveLast();
    }
}

//Do it for last line
partOneTotal += Logic.PartOne(numberList, symbolList, true);
partTwoTotal += Logic.PartTwo(numberList, symbolList, true);

Console.WriteLine("Part One: " + partOneTotal);
Console.WriteLine("Part Two: " + partTwoTotal);