// See https://aka.ms/new-console-template for more information
Console.Write("Enter your age: ");
var input = Console.ReadLine();

if (int.TryParse(input, out var age))          
{
	if (age < 18)
	{
		Console.WriteLine("\nAccess denied. You must be at least 18 years old.");
	}
    else
    {
        Console.WriteLine("\nAccess granted.");
    }
}
else
{
    Console.WriteLine("\nInvalid input!");
}
