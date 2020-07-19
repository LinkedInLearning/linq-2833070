<Query Kind="Program" />

void Main()
{
	
}

internal static class Example
{
	// example implementation of Cast
	public static IEnumerable<T> Cast<T>(this IEnumerable source)
	{
		foreach (object o in source)
			yield return (T)o;
	}

// example implementation of OfType
	public static IEnumerable<T> OfType<T>(this IEnumerable source)
	{
		foreach (object o in source)
			if (o is T)
				yield return (T)o;
	}
}
