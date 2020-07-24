<Query Kind="Statements" />

// Except: returns members of the first set that don't appear in the second set.


var numbersA = new List<int> { 0, 2, 4, 5, 6, 8, 9, 8 }; // 8 items
var numbersB = new List<int> { 1, 3, 5, 7, 8, 9 };       // 6 items

var q1 = numbersA.Except(numbersB);
var q2 = numbersB.Except(numbersA);
q1.Dump();
q2.Dump();