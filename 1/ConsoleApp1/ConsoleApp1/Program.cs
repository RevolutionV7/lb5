using System;
namespace Task1
{
    class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }
    }

    class Company : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            base.Print(value);
        }
    }

    class Position : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Print(value);
        }
    }

    class NamePerson : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Print(value);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Printer name = new NamePerson();
            name.Print("Dmytro Sosnivskyi");
            Printer company = new Company();
            company.Print("IONAR");
            Printer position = new Position();
            position.Print("Executice manager");
        }
    }
}
