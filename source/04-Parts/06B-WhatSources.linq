<Query Kind="Statements" />

// LINQ to objects works with types
// that Implement IEnumerable<T>
//
// Array are treated specially by the CLR
// Array implements IEnumerable, not IEnumerable<T>
// But for a concrete array CLR alters it to
// Inherit Array
// Implement IEnumerable<T>, ICollection<T>, and IList<T>
// Provided the array is single dimensional and zero–lower bound. 


Double[] array = new Double[] { 4.4, 2.2, 6.6 };

var q2 = from a in array
		 orderby a
		 select a;

q2.Dump();