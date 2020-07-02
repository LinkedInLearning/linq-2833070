<Query Kind="Program" />

void Main()
{
	var c = new List<Int32> { 1, 2, 5, 4 };
	var b = new double[] { 1.2, 2.3, 3.4 };
	var d = new ArrayList { "hello", 1, 3.4 };

	var w = new Website
	{
		Tags = { "Flowers", "Tools", "Trees" },
		Domain = "hardwareforeveryone.com"
	};
}

// Define other methods and classes here
public class Website
{
	public List<String> Tags = new List<String>();
	public string Domain;
}