<Query Kind="Statements" />

var colors = new List<string>
		{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgandy","Purple",
		   "White", "Black", "Blue" ,"Bronze"};
colors.Dump("Original List");
// colors is the source

// Use static methods in Enumerable

// call the Where method, pass an IEnumerable and delegate
var w = Enumerable.Where(colors, c => c.StartsWith("B"));
w.Dump("Use Where method");

// use another method
var a = Enumerable.Last(colors);

a.Dump ("Use Last method");