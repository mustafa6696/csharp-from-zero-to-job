// See https://aka.ms/new-console-template for more information
Console.Write("Enter your age: ");
var input = Console.ReadLine();

if (int.TryParse(input, out var age))
{
    Console.WriteLine($"Your age after 5 years: {age + 5}");
}
else
{
    Console.WriteLine("Invalid input");
}