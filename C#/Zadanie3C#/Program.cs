using System;

class Program
{
    static void Main(string[] args)
    {
           Console.WriteLine("Podaj liczbe ocen: ");
           double liczbaOcen = Convert.ToDouble(Console.ReadLine());
           double suma = 0;

           for (int i = 0; i < liczbaOcen; i++) {
                Console.WriteLine($"Podaj ocene: ");
                double ocena = Convert.ToDouble(Console.ReadLine());
                suma += ocena;
           }
              double srednia = suma / liczbaOcen;
              
              if (srednia>=3.0)
              {
                Console.WriteLine($"Średnia: {srednia}");
                Console.WriteLine("Uczeń zdał.");
              }
              else
              {
                Console.WriteLine($"Średnia: {srednia}");
                Console.WriteLine("Uczeń nie zdał.");
              }
        
    }
}