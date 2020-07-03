<Query Kind="Statements" />

// The execution of a query is distinct from the creation of the query. 
// You do not retrieve any data just by creating a query. 

var numbers = new List<int> { 5, 4, 3, 2, 1, 9, 8, 7, 6 };

// this is the potential query
var q = from n in numbers
				orderby n
				select n;

// run it
var numsAsArray = q.ToArray();

// run it again
var asList = q.ToList();

// old school way to run
foreach (var item in q)
{
	Console.WriteLine(item);
}