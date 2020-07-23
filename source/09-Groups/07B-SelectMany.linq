<Query Kind="Statements" />

// SelectMany is also useful for joining similar lists

var setA = Enumerable.Range(2, 3);
var setB = Enumerable.Range(5, 3);

var basicSelect = setA.Select(a => setB.Select(b => $"A {a}, B:{b}"));
var basicJoin = setA.SelectMany(a => setB.Select(b => $"A:{a} B:{b}"));
basicSelect.Dump();
basicJoin.Dump();