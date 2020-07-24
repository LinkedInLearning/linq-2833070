<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// challenge

// GroupBy uses an expression to determine the group 'key'
// and which sequence items belong in that group

// any valid expression is possible, including calcuations

// 1.
// Write a query expression that groups by RedPercent
// there will be a lot of groups, because there are percent values
// like 0.5450981, 0.9803922
// 2. 
// Modify the group by to use rounded percent numbers
// like 0.54, 0.98
// this will reduce the number of groups.

// 3.
// Create another query expression to group by multiple criteria
// GreenPercent and BluePercent.
// Suggestion, look at using anonymous type for the group criteria
// 
var colors = CourseLib.ColorSource.GetColors();

var q = from color in colors
				group color by color.HSL.Saturation;

q.Dump();