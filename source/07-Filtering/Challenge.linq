<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// challenge

// The ColorSource data has some invalid data 
// in the ColorName and HexValue properties.

// 1.
// Write a query expression that finds ColorName values that contain hyphens ("-")
// Also find HexValues that are not valid hexadecimal values (0-9, A, B, C, D, E, F)
// FFFF00 is valid
// FF34T3 is invalid because it has an invalid char (T)

// Combine both these tests into a single query expression!



// use this data source
// CourseLib.ColorSource.GetColors()