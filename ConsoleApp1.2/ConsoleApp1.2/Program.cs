// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input number");

var input = Console.ReadLine();

bool isNumeric = int.TryParse(input, out _);
if (isNumeric)
{
    Console.WriteLine("you've input number: " + input);
}
else
{
    Console.WriteLine("you've input NOT a number: " + input);
}