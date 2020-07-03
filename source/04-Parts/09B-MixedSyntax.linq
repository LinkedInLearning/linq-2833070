<Query Kind="Statements" />

var colors = new List<string>
		{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgandy","Purple",
		   "White", "Black", "Blue" ,"Bronze", "Gray"};

var q1 = colors.Where(c => c.StartsWith("G"));

var q2 = from color in q1
		 orderby color
		 select color;


q2.Dump();

// use Count on Query Expression

var q3 = (from color in colors
		  where color.StartsWith("G")
		  select color).Count();
q3.Dump();