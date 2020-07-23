<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// The Where clause filters the sequence based on a predicate function
// The predicate is applied to each element in the sequence.
// define a predicate that uses a boolean expression 
// to determine what to return in filtered sequence


var q = from color in CourseLib.ColorSource.GetColors()
				where (false)
				select color;
				
q.Dump();

