<Query Kind="Program">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

void Main()
{
	// select returns a sequence of the chosen type
	// IEnumerable<string>, IEnumerable<Product>
	//

	// In other cases, return a sequence of different type


	var q1 = from color in CourseLib.ColorSource.GetColors()
					 orderby color.ColorName
					 select new SimpleColor { ColorCategory = color.ColorFamily.ToString(), Hexadecimal = color.HexValue };

	q1.Dump("IEnumerable<SimpleColor>");

}

// Define other methods and classes here
public class SimpleColor
{

	public string ColorCategory { get; set; }
	public string Hexadecimal { get; set; }
	public bool IsPrimaryColor { get; set; }
}