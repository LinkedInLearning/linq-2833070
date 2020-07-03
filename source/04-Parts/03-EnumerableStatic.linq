<Query Kind="Statements" />

var colors = new List<string>
		{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgandy","Purple",
		   "White", "Black", "Blue" ,"Bronze"};
			 
colors.Dump("Original List");
// colors is the source

// Use static methods in Enumerable

// call the Where method, pass an IEnumerable and delegate
var w = Enumerable.Where(colors, c => c.StartsWith("B"));

// run the query 

foreach (var element in w)
{
	Console.WriteLine (element);
}

// run the query
w.Dump("Use Where method");

// use another method
var a = Enumerable.Last(colors);

a.Dump ("Use Last method");