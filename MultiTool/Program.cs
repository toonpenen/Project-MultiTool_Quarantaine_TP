using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij de multitool applicatie. Maak uw keuze:");
            Console.WriteLine("1.Rekenmachine");
            Console.WriteLine("2.Password tester");
            Console.WriteLine("3.Recyclage");
            Console.WriteLine("4.Computersolver");
            int keuze = Convert.ToInt32(Console.ReadLine());
            switch (keuze)
            {
                case 1:
                    //Hier rekenmachine code
                    Console.WriteLine("Geef getal 1");
                    int getal1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Geef getal 2");
                    int getal2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Welke bewerking wil je doen? (+,-,*,/,%)");
                    char keuzebew = Convert.ToChar(Console.ReadLine());
                    double result = 0;
                    if (keuzebew == '+')
                    { result = getal1 + getal2; }
                    else if (keuzebew == '-')
                    { result = getal1 - getal2; }
                    else if (keuzebew == '*')
                    { result = getal1 * getal2; }
                    else if (keuzebew == '/')
                    { result = getal1 / getal2; }
                    else if (keuzebew == '%')
                    { result = getal1 % getal2; }

                    if (result < 0)
                        Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine($"Uitkomst is:{result}");
                    break;
                case 2:
                    //Hier password tester code
                    Console.WriteLine("Geef paswoord");
                    const string MAINPASS = "TrumpSux";
                    string inputPass = Console.ReadLine();
                    if (inputPass == MAINPASS)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Toegelaten");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Verboden");
                    }
                    break;
                case 3:
                    //Hier recyclage code
                    break;
                case 4:
                    //Hier computersolver code
                    Console.WriteLine("Does the computer turn on?(y/n)");
                    string inp = Console.ReadLine();
                    if (inp == "y")
                    {
                        Console.WriteLine("Are there any messages?");
                        inp = Console.ReadLine();
                        if (inp == "y")
                        {
                            Console.WriteLine("Perform a search for the error message");
                        }
                        else
                        {
                            Console.WriteLine("Computer is fine");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Is the computer light on?");
                        inp = Console.ReadLine();
                        if (inp == "y")
                        {
                            Console.WriteLine("Turn the computer monitor on");
                        }
                        else
                        {
                            Console.WriteLine("Check the computer power cord");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Onbekend keuze ingevoerd. Voer getal tussen 1 en 4 in");
                    break;
            }
        }
    }
}
