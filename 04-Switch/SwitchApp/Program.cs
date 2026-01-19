// See https://aka.ms/new-console-template for more information
Console.WriteLine("Choose an option: ");
Console.WriteLine("1 - Add");
Console.WriteLine("2 - Update");
Console.WriteLine("3 - Delete");

Console.Write("Your choice: ");
var input = Console.ReadLine();

switch (input)
{
    case "1":
        Console.WriteLine("Add operation selected.");
        break;

    case "2":
        Console.WriteLine("Update operation selected.");
        break;

    case "3":
        Console.WriteLine("Delete operation selected.");
        break;

    default:
        Console.WriteLine("Invalid selection");
        break;
}

//var message = input switch
//{
//    "1" => "Add operation selected.",
//    "2" => "Update operation selected.",
//    "3" => "Delete operation selected.",
//    _ => "Invalid selection"
//};