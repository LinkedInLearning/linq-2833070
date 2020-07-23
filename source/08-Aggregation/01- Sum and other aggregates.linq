<Query Kind="Statements" />

// aggregate, given a sequence (a,b,c,d,e)
// perform an operation with each sucessive pair

// result = operation(a, b)
// result = operation (b, result)
// result = operation (c, result)
// result = operation (d, result)
// result = operation (e, result)


var numbers = new List<int> { 50, 4, 10, 3, 90, 8, -60, 7, 20, 5 };

var total = numbers.Sum();
var median = numbers.Average();

var lowest = numbers.Min();
var highest = numbers.Max();

var countOf = numbers.Count();
// count take a optional predicate lambda
var anotherCountOf = numbers.Count(n => n > 20);

total.Dump("Sum");
median.Dump("Average");
lowest.Dump("Min");
highest.Dump("Max");
countOf.Dump("Count");
anotherCountOf.Dump("Count with predicate");