<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
  <Namespace>System.Runtime.Serialization</Namespace>
</Query>

// OfType operator is used to return only the elements of a specified type.
var q = from card in CourseLib.CardSource.GetCards()
				select card;
				
		
var monstersOnly = q.OfType<CourseLib.Cards.Monster>();
//monstersOnly.Select(c => new {c.Name, c.ListPrice, c.TypeName}).Dump();
//q.OfType<ISerializable>().Dump();
q.Dump();