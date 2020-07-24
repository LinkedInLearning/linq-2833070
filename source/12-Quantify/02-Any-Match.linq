<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

var colors = CourseLib.ColorSource.GetColors();
// Any: Determines whether any element of a sequence exists or satisfies a condition.
//       Stops evaluation as soon as it find member that satisfies
// Takes an predicate as a parameter


bool hasMatchingItem = colors.Any(w => w.ColorName.StartsWith("C"));
hasMatchingItem.Dump("'C' found");

var q = from c in colors
				where c.ColorName.StartsWith("C")
				select c.ColorName;
				
q.Dump();

bool hasMaxBlue = colors.Any(c => c.BlueValue >=255);
hasMaxBlue.Dump("Max Blue");