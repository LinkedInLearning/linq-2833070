<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// All: returns whether all the elements in the input sequence 
// match the given predicate 
var colors = CourseLib.ColorSource.GetColors();

var numbers = new List<int> { 25, 18, 16, 76, 140, 24 ,-10};

var areEven = numbers.All(x => x % 2 == 0);

areEven.Dump("All are even numbers.");

var hasTwoDigits = numbers.All(n => Math.Floor(Math.Log10(Math.Abs(n)) + 1) == 2);

hasTwoDigits.Dump("All have two digits.");