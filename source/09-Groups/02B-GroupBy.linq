<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

 var numbers = Enumerable.Range (1,90);
 
 var groupedResult = from number in numbers
 										group number by number % 10 ;

groupedResult.Dump(); 