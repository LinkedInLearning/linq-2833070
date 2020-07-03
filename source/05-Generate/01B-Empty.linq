<Query Kind="Statements" />


var numbers1 = new List<int> { 1, 3, 5, 7, 2, 4, 6, 8 };
var numbers2 = Enumerable.Empty<int>().ToList();



var listOfInts1 = Enumerable.DefaultIfEmpty<int>(numbers1);

// When the source enumerable has no entries, 
// return an enumerable with a single value; the default value.
var listOfInts2 = Enumerable.DefaultIfEmpty<int>(numbers2);


listOfInts1.Dump();
listOfInts2.Dump();

var listOfStrings = Enumerable.DefaultIfEmpty(Enumerable.Empty<string>().ToList());

listOfStrings.Dump();