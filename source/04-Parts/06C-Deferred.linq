<Query Kind="Statements" />

// deferred execution with extension methods.
var colors = new List<string>() {"Blue", "Crimson", "Brown", "Caramel",
								"Copper","Orange" };


var q = colors.Where(c => c.StartsWith("C"));

// run the query

q.Dump("first run");

colors.Add ("Coral");

q.Dump("second run");


// modify the query

var q2 = q.OrderBy(c => c);

q2.Dump("third run");