<Query Kind="Statements" />

// Take:  Get a consecutive subset of the sequence
// Skip:  Skip a consecutive subset of the sequence
var numbers = Enumerable.Range(1,50);

numbers.Take(5).Dump();

numbers.Skip(40).Dump();

numbers.Skip(11).Take(3).Dump();

numbers.Skip(2).Take(10).Dump();