<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// Select can use expressions to set the value


var q = from color in CourseLib.ColorSource.GetColors()
				orderby color.ColorName
				select new { DetailedName = $"{color.ColorFamily}: {color.ColorName.ToString()}"};

q.Dump("Select with an expression");