<Query Kind="Statements" />

// define a function to call from custom aggregator

var setA =	Enumerable.Range(1, 20).Where(x => x % 3 == 0);


var multipleOf = setA.Aggregate((first, second) => first * second);

// set the initial seed (accumulator value)
var anotherMultipleOf = setA.Aggregate(120,(first, second) => first * second);

setA.Dump();
multipleOf.ToString("N0").Dump();
anotherMultipleOf.ToString("N0").Dump();