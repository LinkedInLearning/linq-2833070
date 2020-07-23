<Query Kind="Program">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

void Main()
{

	var q = from color in CourseLib.ColorSource.GetColors()

					where IsColorTotalLessThan(color, 1.5)
					select new
					{
						color.ColorName,
						color.BluePercent,
						color.GreenPercent,
						color.RedPercent,
						TotalPercent = color.BluePercent +
													 color.GreenPercent +
													 color.RedPercent
					};

	q.OrderBy(x => x.TotalPercent).Dump();


}

// Define other methods and classes here
public bool IsColorTotalLessThan(CourseLib.WebColor color, double maxValue)
{
	var total = color.BluePercent + color.GreenPercent + color.RedPercent;

	return total < maxValue;
}