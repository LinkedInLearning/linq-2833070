<Query Kind="Statements" />

// Dump() is an extension method
// Created by the LINQPad team

// Outputs formatted data to the results window

int x = 65;
bool isBig = x > 1000;
string isBigString = isBig ? "Big Number" : "Small number";

x.Dump();

//// add header
//x.Dump("X value");
//
//isBig.Dump ("IsBig");
//
//isBigString.Dump("isBigString");