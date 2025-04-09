using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
           Console.WriteLine("Wybierz konwersje: ");
           Console.WriteLine("C - Celcjusz na Fahrenheit ");          
           Console.WriteLine("F - Fahrenheit na Celcjusz ");
           string konwersja = Console.ReadLine();
           Console.WriteLine("Podaj wartość: ");
           double wartosc = Convert.ToDouble(Console.ReadLine());

           switch (konwersja) {

            case "F":
            double FahrenheitNaCelcjusz = (wartosc - 32) / 1.8;
            Console.WriteLine($" {wartosc}°F =  {FahrenheitNaCelcjusz}°C");
            break;
            case "C":
            double CelcjuszNaFahrenheit = wartosc * 1.8 + 32;
            Console.WriteLine($" {wartosc}°C =  {CelcjuszNaFahrenheit}°F");
            break;
            default:
                Console.WriteLine("Nieprawidłowy wybór. ");
                break;

           }

    }
}