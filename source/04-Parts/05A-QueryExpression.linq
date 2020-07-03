<Query Kind="Statements" />

var colors = new List<string>
		{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgandy","Purple",
		   "White", "Black", "Blue" ,"Bronze"};

var numbers = new List<int> { 2, 4, 6, 8, 100, 200, 300, 1, 3, 5, 7, 400 };
// start with 
// from varname in sequence

var q1 = from n in numbers
		 			select n;

q1.Dump("Simple pass through query");

var q2 = from n in numbers
		 orderby n descending
		 select n;

q2.Dump("add OrderBy clause");

// add another clause
var q3 = from n in numbers
		 orderby n 
		 where n % 100 ==0
		 select n;

q3.Dump("add where clause");

var q4 = from n in numbers
		 orderby n
		 where n % 100 == 0
		 select (n + 50);
q4.Dump("change select clause");