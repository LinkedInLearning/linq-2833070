<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// A new datasource
// from a .NET assembly DLL

// see the visual studio project to examine the code

// be sure and add a reference to the DLL (Press F4 in LINQPad)

CourseLib.ColorSource.GetColors().Dump();