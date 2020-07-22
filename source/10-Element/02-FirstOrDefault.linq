<Query Kind="Statements" />

// The First and Last methods throw an exception if source contains no elements. 


// use FirstOrDefault, LastOrDefault

List<int> numbers = new List<int> { 50, 4, 10, 3, 90, 8, -60, 7, 20, 5 };

List<int> emptyNumbers = new List<int>();
List<string> emptyStrings  = new List<string>();
List<bool> emptyBools  = new List<bool>();


numbers.FirstOrDefault().Dump("Valid sequence");
emptyNumbers.FirstOrDefault().Dump("Empty int sequence");

emptyStrings.FirstOrDefault().Dump("Empty string sequence");

emptyBools.LastOrDefault().Dump("Empty bool sequence");
