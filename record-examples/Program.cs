using record_examples.Models;

//Example 01 -Immutability
var personExample01 = new ImmutablePerson("Carlos", "Souza", 38);
Console.WriteLine("Example01: Immutability");
Console.WriteLine("-> It's not possible change the properties after initialization");
Console.WriteLine(personExample01.ToString());

/*
** Error **
personExample01.FirstName = "Carlos Eduardo";
*/
