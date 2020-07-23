<Query Kind="Statements" />

var colors = new List<string>
		{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgandy","Purple",
		   "White", "Black", "Blue" ,"Bronze"};

// From Microsoft docs:

// Query syntax and method syntax are semantically identical, 
// but many people find query syntax simpler and easier to read. 
// Some queries must be expressed as method calls. 
// For example, you must use a method call to express a query 
// that retrieves the number of elements that match a specified condition

var q1 = from color in colors
		where color.StartsWith("B")
		select color;

q1.Dump();


// use an extension method on query variable

var count = q1.Count();

count.Dump("Count method");