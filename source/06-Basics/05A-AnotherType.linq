<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>


// use select to return a sequence of different type


var q1 = from color in CourseLib.ColorSource.GetColors()
						select color.BlueValue;
						
q1.Dump("IEnumerable<int>");

var q2 = from color in CourseLib.ColorSource.GetColors()
				select color.ColorName;

q2.Dump("IEnumerable<string>");