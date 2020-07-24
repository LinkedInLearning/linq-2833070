<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// var groupedByColorFamily = colors.GroupBy(keySelector: x => x.ColorFamily,
//                               elementSelector: y => new { y.ColorName, y.HexValue });
var colors = CourseLib.ColorSource.GetColors();

var q = from color in colors
				let colorShort = new { color.ColorName, color.HexValue, color.ColorFamily } 
				group colorShort by colorShort.ColorFamily // key selector
				into familyGroup // variable used in resultSelector
				// result selector
				select new { Family = familyGroup.Key, Colors = familyGroup }; 


q.Dump();