<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>


var colors = CourseLib.ColorSource.GetColors();
// use element selector to specify what properties on the members of the group

var groupedByColorFamily = colors.GroupBy(keySelector: x => x.ColorFamily,
														 elementSelector: y => new { y.ColorName, y.HexValue });

groupedByColorFamily.Dump();