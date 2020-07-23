<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// Query expressions must end with a select or groupby clause!

// Let's start with the GroupBy extension method


var groupedByColorFamily = CourseLib.ColorSource.GetColors().GroupBy(x => x.ColorFamily );

groupedByColorFamily.Dump();