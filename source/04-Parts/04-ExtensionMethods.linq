<Query Kind="Statements" />

var colors = new List<string>
		{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgandy","Purple",
		   "White", "Black", "Blue" ,"Bronze"};
colors.Dump("Original List");

// call with extension method syntax
var w = colors.Where(c => c.StartsWith("B"));

w.Dump();

// or

colors.First().Dump();