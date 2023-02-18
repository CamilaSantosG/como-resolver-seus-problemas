// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string op1;
 string op2;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Como resolver seus problemas");
Console.ResetColor();
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("Se pergunte: fui eu?");
Console.WriteLine("");
Console.WriteLine("Sim:s");
Console.WriteLine("Não:n");
Console.Write("Escolha uma opção:");
op1 = Console.ReadLine()!;
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"{op1}");
Console.ResetColor();

///decisão///
switch (op1.ToUpper())
{
   case "N":
   Console.ResetColor();
   Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Não é problema seu");
    Console.ResetColor();
    break;
    case "S":
    Console.Clear();
    Console.WriteLine("Dá pra resolver?");
    Console.ResetColor();
    
Console.WriteLine("Sim:s");
Console.WriteLine("Não:n");
op2 = Console.ReadLine()!;

switch (op2.ToUpper())
{
    case "S":
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Resolve");
    Console.ResetColor();
    
    break;
    case "N":
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Não é problema seu");
    Console.ResetColor();
    
    break;
}
    break;
    
}