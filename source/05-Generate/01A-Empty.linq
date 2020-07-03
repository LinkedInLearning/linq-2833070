<Query Kind="Statements" />

// The Enumerable class 
// contains methods to generate IEnumerable sources

// Empty : Returns a zero length Array<T>
// low memory usage

// useful for a starting value, or as a empty parameter for method.
var listOfDates1 = Enumerable.Empty<DateTime>(); 

listOfDates1.GetType().Name.Dump("listOfDates1 Type");
listOfDates1.Count().Dump("Count of Array");
listOfDates1.Dump("Array contents");


List<DateTime> listOfDates2 = Enumerable.Empty<DateTime>().ToList();

listOfDates2.GetType().Name.Dump("listOfDates2 Type");
listOfDates2.Dump();