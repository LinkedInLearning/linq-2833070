<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// Contains:  return whether a specified item is contained in the sequence.
// takes a object as a parameter
var numbers = new List<int> { 24, 18, 16, 76, 14, 24, -10 };
var containsNumber = numbers.Contains(14);

containsNumber.Dump("Contains 14");

var colors = CourseLib.ColorSource.GetColors();
var colorRef1 = new CourseLib.WebColor { ColorName = "DirtBrown", ColorFamily = CourseLib.ColorFamily.Brown };
var colorRef2 = colors.ElementAt(101);

var containsBrown = colors.Contains(colorRef1);
containsBrown.Dump("Contains DirtBrown");

var containsOther = colors.Contains(colorRef2);
containsOther.Dump("Contains Other");