// See https://aka.ms/new-console-template for more information
using _2._2;

decimal euroToHryv=30, dolToHryv = 35;
Converter conv = new Converter(dolToHryv, euroToHryv);

Console.WriteLine(conv.ToHryvnya(12, "dol"));
Console.WriteLine(conv.ToHryvnya(12, "euro"));
Console.WriteLine(conv.FromHryvnya(12, "dol"));
Console.WriteLine(conv.FromHryvnya(12, "euro"));
Console.WriteLine(conv.FromHryvnya(0, "euro"));
Console.WriteLine(conv.FromHryvnya(12, "dasd"));

 Converter conv2 = new Converter(dolToHryv, euroToHryv);


/*Console.WriteLine("Hello, World!");

Console.WriteLine("excange rate dollar to hryvna: ");
string input = Console.ReadLine();
decimal euroToHryv, dolToHryv;

if (Decimal.TryParse(input, out euroToHryv)) {
}
else {
    Console.WriteLine("Conversion of {0} failed", input);
    throw new ArgumentException(" not a number ");
}


Console.WriteLine("excange rate euro to hryvna: ");
input = Console.ReadLine();

if (Decimal.TryParse(input, out dolToHryv)){
}
else
{
    Console.WriteLine("Conversion of {0} failed", input);
    throw new ArgumentException( " not a number ");
}

Converter conv = new Converter(dolToHryv, euroToHryv);


while(input.ToLower() != "exit")
{
    Console.WriteLine("to Hryvna ()")
}
*/