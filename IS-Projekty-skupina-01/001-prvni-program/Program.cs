using System;

class Program
{
   
        static void Main()
    {
        
        Console.Clear();    
        Console.WriteLine("************************");
        Console.WriteLine("**** Výpis číselné řady ****");
        Console.WriteLine("************************");
        
        // Vstup od uživatele
        // Console.Write("Zadejte první hodnotu: ");
        // int first = int.Parse(Console.ReadLine());

        Console.Write("\nZadejte první hodnotu: ");
        int first;
        while(!int.TryParse(Console.ReadLine(), out first)) {
            Console.Write("Zřejmě jste nezadali celočíselnou hodnotu.\nZadejte první hodnotu: ");
        }
        
        Console.Write("\nZadejte poslední hodnotu: ");
        int last;
        while(!int.TryParse(Console.ReadLine(), out last)) {
            Console.Write("Zřejmě jste nezadali celočíselnou hodnotu.\nZadejte poslední hodnotu: ");
        }

        Console.Write("\nZadejte krok (diferenci): ");
        int step;
        while(!int.TryParse(Console.ReadLine(), out step)) {
            Console.Write("Zřejmě jste nezadali celočíselnou hodnotu.\nZadejte krok (diferenci): ");
        }
        
        
        // Výpis řady čísel
        int current = first; // Začínáme s první hodnotou
        while (current <= last)
        {
            Console.WriteLine(current);
            current = current + step; // Ruční přičítání kroku
        }

        
        Console.WriteLine("Program ukončíte stiskem libovolné klávesy");
        Console.ReadKey();
    }
}

