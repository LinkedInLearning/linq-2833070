<Query Kind="Expression" />

// Let's review some principles
// LINQ query expressions can be categorized into three areas

// 1. Takes a sequence, returns a new sequence containing the same element type.
//    Doubles to Doubles, Strings to Strings, Products to Products, etc.
//    Elements are the same, but may be sorted, grouped, filtered

// 2. Takes a sequence, returns a new sequence containing a different type of element.
//    Transforms the object into another type.
//    Integers to Decimals, Products to Strings

// 3. Takes a sequence, returns a single value.
//    AKA (fold, reduce, aggregate, accumulate, etc.)
//		reduces a list of data to a aggregate value
//    min, max, sum