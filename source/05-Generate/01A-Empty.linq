<Query Kind="Statements" />

// The Enumerable class 
// contains methods to generate IEnumerable sources


var listOfDates1 = Enumerable.Empty<DateTime>(); // returns zero length array


listOfDates1.GetType().Name.Dump("listOfDates1 Type");
listOfDates1.Dump();


List<DateTime> listOfDates2 = Enumerable.Empty<DateTime>().ToList();



listOfDates2.GetType().Name.Dump("listOfDates2 Type");
listOfDates2.Dump();