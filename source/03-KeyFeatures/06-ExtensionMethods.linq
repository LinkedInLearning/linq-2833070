<Query Kind="Program" />

void Main()
{
	var colors = new List<String> { "purple", "yellow", "orange" };
	colors.ShowItems();

	var numbers = new[] { 2, 4, 6, 8 };
	numbers.ShowItems();
	// numbers.Dump("My custom header");

	numbers.ShowItems();

	if (!colors.IsItEmpty())
	{
		Console.WriteLine("The collection has items");
	}
	
	
	

}

// Define other methods and classes here

 static class CollectionExtensions
{

	public static void ShowItems<T>(this IEnumerable<T> collection)
	{
		Console.WriteLine();
		foreach (T item in collection)
		{
			Console.WriteLine(item);
		}
	}

	public static bool IsItEmpty<T>(this ICollection<T> candidateCollection)
	{
		// .Any is faster than collection.Count == 0
		return candidateCollection == null || !candidateCollection.Any();
	}


	public static void Add<T>(this ICollection<T> collection, params T[] items)
	{
		foreach (var item in items)
		{
			collection.Add(item);
		}
	}

}