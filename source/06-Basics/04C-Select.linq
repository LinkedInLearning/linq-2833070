<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// select returns a sequence of the chosen type
// IEnumerable<string>, IEnumerable<Product>
//

// In many cases, this is the same type as original sequence
// in this example, its a  list of same type

var q = from color in CourseLib.ColorSource.GetColors()
					orderby color.ColorFamily
				select color;

q.Dump();

//
//var q = from color in CourseLib.ColorSource.GetColors()
//				where color.ColorFamily == CourseLib.ColorFamily.Orange
//				select color;