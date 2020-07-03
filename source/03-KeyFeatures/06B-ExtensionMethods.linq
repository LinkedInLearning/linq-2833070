<Query Kind="Program" />

void Main()
{
	var colors = new List<String> { "purple", "yellow", "orange" };

	if (!colors.IsItEmpty())
	{
		Console.WriteLine("The collection has items");
	}

	colors.GetRandomElement().Dump();
	colors.Shuffle().Dump();

}

// Define other methods and classes here

static class CollectionExtensions
{
	private static readonly Random _ran = new Random();
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


	public static T GetRandomElement<T>(this ICollection<T> array)
	{
		return array.ElementAt(_ran.Next(array.Count));
	}

	public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> candidate)
	{
		return candidate.OrderBy(x => _ran.NextDouble());
	}

	public static void Add<T>(this ICollection<T> collection, params T[] items)
	{
		foreach (var item in items)
		{
			collection.Add(item);
		}
	}
}