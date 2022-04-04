using dotnet__POO.src.Entities;
using src.Entities;

class Program
{
    static void Main(string[] args)
    {
        Knight knight = new Knight("Arus", 23, "Knight");
        Wizard wizard = new Wizard("Jennica", 24, "White Wizard");
        Ninja ninja = new Ninja("Wedge", 25, "Ninja");
        Wizard blackWizard = new Wizard("Topaza", 25, "Black Wizard");

        Console.WriteLine(knight.Attack());
        Console.WriteLine(wizard.Attack(1));
        Console.WriteLine(wizard.Attack(7));
        Console.WriteLine(ninja.Attack());
        Console.WriteLine(blackWizard.Attack(8));
       
    }
}
