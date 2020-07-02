<Query Kind="Statements" />

// more types that implement IEnumerable

var st = new Stack<bool>();
st.Push(true);
st.Push(true);
st.Push(false);

var q4 = from s in st
		 select s;

q4.Dump();

var dict = new Dictionary<int, string>();
dict.Add(4, "****");
dict.Add(2, "EE");
dict.Add(8, "!!!!!!!!");

var q5 = from d in dict
		 select d;

q5.Dump();
q5.Where(c => c.Key < 5).Dump();