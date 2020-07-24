<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
  <NuGetReference>morelinq</NuGetReference>
  <Namespace>MoreLinq</Namespace>
</Query>

var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };


// Pads a sequence with default values if it is narrower (shorter in length) 
// than a given width.
var resultA = numbers.Pad(10);

resultA.Dump();


// Pads a sequence with default values in the beginning if it is narrower (shorter in length)//  than a given width.
var resultB = numbers.PadStart(12);

resultB.Dump();