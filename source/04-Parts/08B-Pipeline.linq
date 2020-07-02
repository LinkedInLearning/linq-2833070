<Query Kind="Statements" />

var colors = new List<string>
		{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgandy","Purple",
		   "White", "Black", "Blue" ,"Bronze", "Bronze"};


// write pipeline example

// Where returns IEnumerable<T>

var pipe1 = colors.Where(c => c.Length >5);

// OrderBy returns IOrderedEnumerable<T>
var pipe2 = pipe1.OrderBy(p => p.Length);

pipe2.Dump();

// Distinct returns IEnumerable<T>
//var pipe3 = pipe2.Distinct();
//
//pipe3.Dump();