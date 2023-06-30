using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hi mir!");
        SayHelloUser("Nikita");
        PrintFace();
    }
    static void SayHelloUser(string userName)
    {
        Console.WriteLine("HELLO, " + userName + "!");
    }
    static void PrintFace()
    {
        Console.WriteLine("  *******");
        Console.WriteLine(" *       *");
        Console.WriteLine("*  O   O  *");
        Console.WriteLine("*    ^    *");
        Console.WriteLine(" *  \\_/  *");
        Console.WriteLine("  *******");
    }
}