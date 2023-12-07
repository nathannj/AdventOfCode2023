using System.Text.RegularExpressions;

var arr = File.ReadAllLines("TestData.txt");

int i = 0;

var sources = Regex.Matches(arr[i++], @"(\d+)")
.Select(e => Int64.Parse(e.Value))
.ToList();

var list = new List<MappingStruct>();
//Seed to soil
Logic.SortMappings(ref i, ref arr, list, "soil-to-fertilizer map:");
sources = Logic.PartOne(sources, list);
list.Clear();

// Soil to fertilizer
Logic.SortMappings(ref i, ref arr, list, "fertilizer-to-water map:");
sources = Logic.PartOne(sources, list);
list.Clear();

// Fertilizer to water
Logic.SortMappings(ref i, ref arr, list, "water-to-light map:");
sources = Logic.PartOne(sources, list);
list.Clear();

// Water to light
Logic.SortMappings(ref i, ref arr, list, "light-to-temperature map:");
sources = Logic.PartOne(sources, list);
list.Clear();

// Light to temperature
Logic.SortMappings(ref i, ref arr, list, "temperature-to-humidity map:");
sources = Logic.PartOne(sources, list);
list.Clear();

// Temperature to humidity
Logic.SortMappings(ref i, ref arr, list, "humidity-to-location map:");
sources = Logic.PartOne(sources, list);
list.Clear();

//humidity to location
Logic.SortMappings(ref i, ref arr, list, string.Empty);
sources = Logic.PartOne(sources, list);
list.Clear();

Console.WriteLine(sources.Min());