using System.Text.RegularExpressions;
public static class Logic {
    public static int PartOne(string line) {
        var numbers = line.Split(':')[1].Split('|');

        var winningNumbers = Regex.Matches(numbers[0], @"(\d+)")
        .Select(e => e.Value).ToList();

        var playersNumbers = Regex.Matches(numbers[1], @"(\d+)")
        .Select(e => e.Value).ToList();

        var total = 0;

        foreach(var num in playersNumbers) {
            if (winningNumbers.Contains(num)) {
                if (total == 0) {
                    total += 1;
                }
                else {
                    total *= 2;
                }
            }
        }

        return total;
    }

    public static int PartTwo(string line) {
        var numbers = line.Split(':')[1].Split('|');

        var winningNumbers = Regex.Matches(numbers[0], @"(\d+)")
        .Select(e => e.Value).ToList();

        var playersNumbers = Regex.Matches(numbers[1], @"(\d+)")
        .Select(e => e.Value).ToList();

        var total = 0;

        foreach(var num in playersNumbers) {
            if (winningNumbers.Contains(num)) {
                    total += 1;
            }
        }

        return total;
    }
}