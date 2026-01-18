// See https://aka.ms/new-console-template for more information
Console.Write("Adınızı giriniz: ");
var firstName = Console.ReadLine();

Console.WriteLine($"Merhaba, {firstName}");

Console.Write("Yaşınızı giriniz: ");
var input = Console.ReadLine();

if (int.TryParse(input, out var age))
{
    Console.WriteLine($"5 yıl sonraki yaşınız: {age + 5}");
}
else
{
    Console.WriteLine("Geçersiz giriş!");
}