<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.dll</Reference>
</Query>

// a Query consists of a source (sequence) and
// and at least one Query Operator

// All the Query Operators are implemented as extension methods
// and are in the Enumerable class.

var a = Assembly.Load("System.Linq");

var q1 = from method in typeof(System.Linq.Enumerable).GetMethods()
		 orderby method.Name
		 
			select new { Name = method.Name, ReturnType = method.ReturnType.Name.Replace("`1", "<T> " )};
q1.Dump();

var q2 = from method in typeof(System.Linq.Enumerable).GetMethods()
		 orderby method.Name
		 where method.ReturnType.IsGenericType
		 && method.ReturnType.GetGenericTypeDefinition() == typeof(IEnumerable<>)
		 |  method.ReturnType.GetGenericTypeDefinition() == typeof(IOrderedEnumerable<>)
		 select new { Name = method.Name, ReturnType = method.ReturnType.Name.Replace("`1", "<T> ") };
q2.Dump();


