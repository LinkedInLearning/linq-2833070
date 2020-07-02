<Query Kind="Statements" />

var colors = new List<string>
		{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgandy","Purple",
		   "White", "Black", "Blue" ,"Bronze"};

// add additional expressions

var q = from x in colors
		where x.Length > 5
		orderby x
		select x;

q.Dump("More expressions");