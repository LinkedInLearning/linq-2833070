<Query Kind="Statements" />

// basic knowledge of generics is key to work with LINQ

// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/
// .NET allows for creating generic classes, methods, interfaces, delegates

// the type author creates the generic item

// the type user specifies the concrete type


var saleAmounts = new List<decimal> { 21.30M, 92.35M, 14.00M };

var total = saleAmounts.Sum(); 

total.Dump();

IEnumerable<int> numbers= new List<int> {1,3,5,7};

var totalB = numbers.Sum();

saleAmounts.OrderBy(a => a ).Dump();