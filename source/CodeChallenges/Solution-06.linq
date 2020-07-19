<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// My challenge solution
	var q = from color in CourseLib.ColorSource.GetColors()
					orderby color.GreenValue descending
					select new { color.ColorName, 
					Formula = $"rgb ({color.RedValue.ToString("D3")}, {color.GreenValue.ToString("D3")}, {color.BlueValue.ToString("D3")})"};
							
q.Dump();