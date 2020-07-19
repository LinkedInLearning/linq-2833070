<Query Kind="Program">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

void Main()
{
	// My challenge solution
		var q = from color in CourseLib.ColorSource.GetColors()
					where color.ColorName.Contains("-") ||
					IsValidHex(color.HexValue) == false
					orderby IsValidHex(color.HexValue) == false
					select new {color.ColorName, color.HexValue};
								
	q.Dump();
	
}

// Define other methods and classes here
public bool IsValidHex (string candidate)
{
	return int.TryParse(candidate, System.Globalization.NumberStyles.HexNumber, null, out _);
}