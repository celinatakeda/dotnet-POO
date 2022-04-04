using dotnet__POO.src.Entities;
using src.Entities;

class Program
{
    static void Main(string[] args)
    {
        Knight knight = new Knight("Arus", 23, "Knight");
        Wizard wizard = new Wizard("Jennica", 24, "White Wizard");

        //Console.WriteLine(knight.Attack());
        Console.WriteLine(wizard.Attack(1));
        Console.WriteLine(wizard.Attack(7));
       
    }
}
