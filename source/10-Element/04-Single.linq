<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// Single: Returns the only element of a sequence that satisfies 
// a specified condition, and throws an exception if more than one such element exists.

// SingleOrDefault: Returns a single, specific element of a sequence, or a default value if that element is not found.

var colors =  CourseLib.ColorSource.GetColors();
colors.Single(x => x.ColorName =="SteelBlue").Dump("Single");
colors.SingleOrDefault(x => x.ColorName =="DirtBrown").Dump("SingleOrDefault");