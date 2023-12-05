var arr = File.ReadAllLines("TestData.txt");
var partOneTotal = 0;
var partTwoTotal = 0;

List<int> copies = new List<int>();

foreach (var line in arr)
{
    partOneTotal += Logic.PartOne(line);  

    var copiesForLine = copies.FirstOrDefault();
    partTwoTotal += 1 * (copiesForLine+1);

    if (copiesForLine > 0) {
        copies.RemoveAt(0);
    }

    var matchingNumbers = Logic.PartTwo(line);
    
    while (copies.Count < matchingNumbers) {
        copies.Add(0);
    }

    for (int i = 0; i < matchingNumbers; i++) {
        copies[i] += 1 * (copiesForLine+1);
    }
}

Console.WriteLine("Part one: " + partOneTotal);
Console.WriteLine("Part two: " + partTwoTotal);