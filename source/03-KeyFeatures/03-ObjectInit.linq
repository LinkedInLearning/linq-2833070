<Query Kind="Program" />

void Main()
{
	// Initial properties at the time of instantiation

	var h1 = new House();

	var h2 = new House();
	h2.Floors = 2;

	var h3 = new House { Bathrooms = 2 };
	var h4 = new House { ExternalPaintColor = "Brown" };
	var h5 = new House { ExternalPaintColor = "Yellow", Floors = 3 };
	
	
}

// Define other methods and classes here

public class House
{
	public int Floors;
	public int Bathrooms;
	public string ExternalPaintColor;

	
}