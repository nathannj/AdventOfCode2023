using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

public static class Logic {
    internal static int PartOne(LinkedList<List<Match>> numberList, LinkedList<List<Match>> symbolList, bool lastLine = false)
    {
        var symbolIndexes = symbolList.SelectMany(e => e.Select(f => f.Index));
        var numberMatchesToCheck = lastLine ? numberList?.First?.Value : numberList?.First?.Next?.Value;

        var lineTotal = 0;

        foreach(var match in numberMatchesToCheck ?? new List<Match>()) {
            var stringLength = match.Value.Length;

            var startIndex = match.Index-1;
            var endIndex = match.Index+stringLength;

            if (symbolIndexes.Any(x => x >= startIndex && x <= endIndex)) {
                lineTotal += int.Parse(match.Value);
            }
        }

        return lineTotal;
    }

    internal static int PartTwo(LinkedList<List<Match>> numberList, LinkedList<List<Match>> symbolList, bool lastLine = false)
    {
        var symbolMatchesToCheck = lastLine ? symbolList?.First?.Value : symbolList?.First?.Next?.Value;
        var numberMatchesToCheck = numberList?.SelectMany(e => e.Select(f => f));

        var lineTotal = 0;

        foreach(var symbolMatch in symbolMatchesToCheck ?? new List<Match>()) {
            var adjacentNumberList = new List<int>();
            foreach(var numberMatch in numberMatchesToCheck ?? new List<Match>()) {
            var stringLength = numberMatch.Value.Length;

            var startIndex = numberMatch.Index-1;
            var endIndex = numberMatch.Index+stringLength;

            if (symbolMatch.Index >= startIndex && symbolMatch.Index <= endIndex) {
                adjacentNumberList.Add(int.Parse(numberMatch.Value));
            }
        }

        if (adjacentNumberList.Count == 2) {
            lineTotal += adjacentNumberList[0]*adjacentNumberList[1];
        }
        }

        return lineTotal;
    }
}