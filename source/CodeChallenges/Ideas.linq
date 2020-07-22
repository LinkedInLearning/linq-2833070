<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
  <Namespace>CourseLib</Namespace>
</Query>

// find which colors have a hyphen

// add nested struct to webcolor class
// color.RBG.Red, color.HSL.Hue

// all green and blue values > 128

// project out type with # symbol in front of hex color

// where: find palindromes
//https://www.colorschemer.com/color-names/


// select returns a sequence of the chosen type
// IEnumberable<string>, IEnumberable<Product>
////
//var q = from color in CourseLib.ColorSource.GetColors()
//				group color by color.ColorFamily;
//CourseLib.ColorSource.GetColors().Count.Dump();
//q.Dump();
//var q = from color in CourseLib.ColorSource.GetColors()
//				orderby color.ColorName
//				where color.HSL.Saturation > 50
//				select new { color.ColorName, color.HSL };





var results = new List<WebColor>()
var colors = CourseLib.ColorSource.GetColors();

foreach (var color in colors)
{
	if (color.HSL.Saturation > 50)
	{
		results.Add(color);
	}
}
results.Sort((a, b) => (a.ColorName[0].CompareTo(b.ColorName[0])));



var q = from color in CourseLib.ColorSource.GetColors()
				orderby color.ColorName
				where color.HSL.Saturation > 50
				select color;
				
				
