using System;

class Program
{
    

        static void Main()
    {
        
        // Vstup od uživatele
        // Console.Write("Zadej první hodnotu: ");
        // int first = int.Parse(Console.ReadLine());

        // Vstup od uživatele s kontrolou na celé číslo (bez metody)
        int first;
        while (true)
        {
            Console.Write("Zadej první hodnotu: ");
            if (int.TryParse(Console.ReadLine(), out first))
            {
                break; // Platné číslo, opustit cyklus
            }
            else
            {
                Console.WriteLine("Nezadal(a) jsi celé číslo. Zkus to znovu.");
            }
        }

        int last;
        while (true)
        {
            Console.Write("Zadej poslední hodnotu: ");
            if (int.TryParse(Console.ReadLine(), out last))
            {
                break; // Platné číslo, opustit cyklus
            }
            else
            {
                Console.WriteLine("Nezadal(a) jsi celé číslo. Zkus to znovu.");
            }
        }

        int step;
        while (true)
        {
            Console.Write("Zadej krok: ");
            if (int.TryParse(Console.ReadLine(), out step))
            {
                break; // Platné číslo, opustit cyklus
            }
            else
            {
                Console.WriteLine("Nezadal(a) jsi celé číslo. Zkus to znovu.");
            }
        }

        // Výpis řady čísel
        int current = first; // Začínáme s první hodnotou
        while (current <= last)
        {
            Console.WriteLine(current);
            current = current + step; // Ruční přičítání kroku
        }

        Console.ReadKey();
    }
}

