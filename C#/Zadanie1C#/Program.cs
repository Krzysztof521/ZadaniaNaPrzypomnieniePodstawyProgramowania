using System;

class Program
{
    static void Main() {
        double wynik;
        Console.WriteLine("Podaj liczbe a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Podaj liczbe b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Wybierz operacje: +, -, * lub / ");
        string znak = Console.ReadLine();
        
        if (znak=="+") {
            wynik = a + b;
            Console.WriteLine(wynik);
        }
        else if (znak=="-") {
            wynik = a - b;
            Console.WriteLine(wynik);
        }
        else if (znak=="*") {
            wynik = a * b;
            Console.WriteLine(wynik);
        }
        else if (znak=="/") {
            wynik = a / b;
            Console.WriteLine(wynik);
        }
    }
}