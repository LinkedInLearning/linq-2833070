<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// select returns a sequence of the chosen type
// IEnumerable<string>, IEnumerable<Product>
//

// Transform type with an anonymous type


var q = from color in CourseLib.ColorSource.GetColors()
				orderby color.ColorName
				select new {Name = color.ColorName,Family= color.ColorFamily};

q.Dump("Sequence of anonymous type");