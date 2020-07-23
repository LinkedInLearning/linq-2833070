<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// Where:  any valid boolean expression is acceptable

// Use &&, &, ||, | , !, ^


var q1 = from color in CourseLib.ColorSource.GetColors()
				where color.ColorFamily == CourseLib.ColorFamily.Orange
				&& color.ColorName.Contains("")
				select color;


q1.Dump("&&");

var q2 = from color in CourseLib.ColorSource.GetColors()
				 where color.ColorFamily == CourseLib.ColorFamily.Blue
				 ||    color.ColorFamily == CourseLib.ColorFamily.Yellow
				 select color;


q2.Dump("||");