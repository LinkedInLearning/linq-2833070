<Query Kind="Statements" />

var colors = new List<string>
		{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgandy","Purple",
			 "White", "Black", "Blue" ,"Bronze"};

// The Query expression syntax is a substitute for calling the 
// the query operator extension methods.

// There are additional words  needed for a valid query expression.
// Also known as clauses

// required in all query expressions
// [from, in ]

// required, query expression must end with one of these clauses
// [select, group]

// optional
// [where, orderby, join, let, from]

 IEnumerable<string> q1 = from c in colors
				                  select c;
 IEnumerable<string> q2 = colors.Select(c => c );			
q1.Dump();