<Query Kind="Statements" />

var colors = new List<string>
		{ "Green", "Blush", "Yellow",  "Red", "Orange", "Burgandy","Purple",
			 "White", "Black", "Blue" ,"Bronze"};
var emptyList = new List<double>();
// Any:  Check for empty list
// Stops evaluation as soon as it find a item that satisfies


// look at the Count vs. Any methods
// both are useful to determine if a sequence has values
colors.Count().Dump("colors count");
emptyList.Count().Dump("emptyList count");
// vs.
colors.Any().Dump("colors Any");
emptyList.Any().Dump("emptyList Any");

// one issue with using the aggregate Count method
// is that it iterates the entire sequence
if (colors.Count() > 0)
{
	"Items in colors!".Dump();
}
else
{

	"Colors is empty!".Dump();
}

// this is a better approach!
if (colors.Any())
{
	"Items in colors!".Dump();
}
else
{

	"Colors is empty!".Dump();
}
