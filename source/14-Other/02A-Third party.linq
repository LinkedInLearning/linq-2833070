<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
  <NuGetReference>morelinq</NuGetReference>
  <Namespace>MoreLinq</Namespace>
</Query>

// LINQ provides many useful Enumerable methods.

// Many are implemented as Extension methods
// It's possible to create more extension methods to add other query operations..

// MoreLinq is available as a NuGet package https://morelinq.github.io/
// Examples at https://github.com/morelinq/examples
;
var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

var resultA = numbers.Move(3,numbers.Count(),0);

resultA.Dump();

var resultB = numbers.Move(4,numbers.Count(),2);

resultB.Dump();