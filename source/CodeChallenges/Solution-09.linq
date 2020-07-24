<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

var colors = CourseLib.ColorSource.GetColors();

var q1 = from color in colors
				 group color by Math.Round(color.RedPercent, 2); // key selector


var q2 = from color in colors
				group color by new { color.BlueValue, color.GreenValue}; // key selector




q1.Dump();
//q2.Dump();