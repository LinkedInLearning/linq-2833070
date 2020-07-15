<Query Kind="Statements" />

// 2. Takes a sequence, returns a new sequence containing a different type of element.
//    Transforms the object into another type.
//    Integers to Strings, Products to Strings

IEnumerable<string> colors = new List<string>
		{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgandy","Purple",
			 "White", "Black", "Blue" ,"Bronze"};


// this query takes a list of strings and returns a list of ints.
IEnumerable<int> q1 = from c in colors
												 select c.Length;



q1.Dump("Word Length" );
