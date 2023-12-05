var arr = File.ReadAllLines("TestData.txt");
var total = 0;

foreach (var line in arr)
{
    total += Logic.PartTwo(line);   
}

Console.WriteLine(total);