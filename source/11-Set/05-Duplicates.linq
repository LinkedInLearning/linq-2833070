<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// Distinct removes all the duplicate items
// what about a scenario where you want to find duplicates instead?


// at first it seems possible to use Distinct and another Set function.
// however that doesn't seem possible

// instead use the group by clause

//var hexValues = CourseLib.ColorSource.GetColors().Select(x=>x.HexValue);
//hexValues.Distinct().Dump();

var q1 = from color in CourseLib.ColorSource.GetColors()
				 group color by color.HexValue into hex
				 where hex.Count() > 1
				 select hex;
q1.Dump();

// use extension methods

var q2 = CourseLib.ColorSource.GetColors().GroupBy(g => g.HexValue).Where(x => x.Count() > 1);

q2.Dump("Extension methods");