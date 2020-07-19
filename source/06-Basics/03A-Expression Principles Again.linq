<Query Kind="Statements" />

// Let's review some principles
// LINQ query expressions can be categorized into three areas

// 1. Takes a sequence, returns a new sequence containing the same element type.
//    Doubles to Doubles, Strings to Strings, Products to Products, etc.
//    Elements are the same, but may be sorted, grouped, filtered


IEnumerable<string> colors = new List<string>
		{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgandy","Purple",
			 "White", "Black", "Blue" ,"Bronze"};


// this query takes a list of strings and returns a list of strings.
IEnumerable<string> q1 = from c in colors
												 select c;

// same here, but filtered and sorted
IEnumerable<string> q2 = from c in colors
												 where c.EndsWith("e")
												 orderby c
												 select c;
												 
q1.Dump("<string>");
q2.Dump("<string>");