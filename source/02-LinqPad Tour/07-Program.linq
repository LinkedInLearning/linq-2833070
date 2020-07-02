<Query Kind="Program" />

void Main()
{
	var result = GetMagicNumber() + 100;
	
	result.Dump("Call your own methods");
}

// Define other methods and classes here
public int GetMagicNumber()
{
	return 42;
}