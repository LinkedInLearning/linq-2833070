<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.dll</Reference>
</Query>

// a Query consists of a source (sequence) and
// and at least one Query Operator

// All the Query Operators are implemented as extension methods
// and are in the Enumerable class.

var a = Assembly.Load("System.Linq");

var q2 = from method in typeof(System.Linq.Enumerable).GetMethods()
		orderby method.Name
		group method by method.Name into g
		select new { Name = g.Key, Overloads = g.Count() };
q2.Dump();