<Query Kind="Statements" />

var colors = new List<string>
		{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgandy","Purple",
			 "White", "Black", "Blue" ,"Bronze"};



// The Query syntax is a substitute for calling the 
// the query operator extension methods.

// There are additional words needed for a valid query expression.

// [from, in, select ]


 IEnumerable<string> q1 = from c in colors
				                  select c;
 IEnumerable<string> q2 = colors.Select(c => c );			
q2.Dump();