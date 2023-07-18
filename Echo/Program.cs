while (true)
{
    Console.Write("Enter your name > ");
    
    var name = Console.ReadLine();
    if (string.IsNullOrEmpty(name)) break;

    Console.WriteLine($"Hello, {name}.");
}

Console.WriteLine("Bye.");
