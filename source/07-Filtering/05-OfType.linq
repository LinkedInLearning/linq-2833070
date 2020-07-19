<Query Kind="Expression" />

// Enumerable.Cast
// attempts to cast each item to specified type.
// throws an InvalidCastException if not successful

// simplified implementation of CAST

public IEnumerable<T> Cast<T>(this IEnumerable source)
{
	foreach (object o in source)
		yield return (T)o;
}

// Enumerable.OfType
// filters the sequence to type that can be cast to specified type

// OfType is slower, as it has to enumerate the sequence and verify each item is castable


