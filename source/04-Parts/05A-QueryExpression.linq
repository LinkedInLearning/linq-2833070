<Query Kind="Statements" />

var colors = new List<string>
		{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgandy","Purple",
		   "White", "Black", "Blue" ,"Bronze"};

// start with 
// from varname in sequence

var q = from x in colors
		select x;
		
		q.Dump("Simple pass through query");