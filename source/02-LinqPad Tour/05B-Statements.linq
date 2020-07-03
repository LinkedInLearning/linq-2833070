<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.dll</Reference>
  <Namespace>System.Data</Namespace>
</Query>

// LINQPad supports multiple lines
// with the Statement editor


int x = 9865;
bool isBig = x > 1000;
string isBigString = isBig ? "Big Number" : "Small number";

// you decide how to output to the results window!

Console.WriteLine(isBigString);