<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.dll</Reference>
</Query>

// show all types that implement 
// the IEnumerable (LINQ) interface in msCorLib

var a = Assembly.Load("mscorlib");

var q = from t in a.GetExportedTypes()
		from i in t.GetInterfaces()
		where i.IsGenericType && t.IsClass && i.GetGenericTypeDefinition() == typeof(IEnumerable<>)
		orderby t.Name
		select t.Name;


q.Dump();