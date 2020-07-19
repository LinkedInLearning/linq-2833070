<Query Kind="Program">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

void Main()
{
	var numbers = Enumerable.Range(start: 1, count: 15);
	
	var q = from number in numbers
					select new {OriginalNumber = number, X2= number *2,X3= number *3, 
											X5= number *5, X10 =number *10,
											Square= number * number, SquareRoot = Math.Sqrt(number),
											IsPrime = NumberExpressions.IsPrime(number),
											MultiplyInverse = 1.0/number};
					
					q.Dump();
}

// Define other methods and classes here
public static class NumberExpressions
{
	public static bool IsPrime(int candidate)
	{
// simple and 
		if (candidate <= 1) return false;
		if (candidate == 2) return true;
		if (candidate % 2 == 0) return false;

		var boundary = (int)Math.Floor(Math.Sqrt(candidate));

		for (int i = 3; i <= boundary; i += 2)
			if (candidate % i == 0)
				return false;

		return true;
	}

}