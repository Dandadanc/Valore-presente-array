using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_array
{
    internal class Program

    {
        static void Main(string[] args)
        {
            // Daniele Cito 3I3 17/3/2025
            int scelta;
            int[] numeri = { 10, 20, 30, 40, 50 };
            do
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Visualizza array");
                Console.WriteLine("2. Cerca numero");
                Console.WriteLine("3. Esci");
                Console.Write("Scegli un'opzione: ");
                scelta = int.Parse(Console.ReadLine());

                if (scelta == 1)
                {
                    for (int i = 0; i < numeri.Length; i++)
                        Console.Write(numeri[i] + " ");
                    Console.WriteLine();
                }
                else if (scelta == 2)
                {
                    Console.Write("Inserisci numero da cercare: ");
                    int valore = int.Parse(Console.ReadLine());

                    bool trovato = false;
                    for (int i = 0; i < numeri.Length; i++)
                    {
                        if (numeri[i] == valore)
                        {
                            trovato = true;
                            break;
                        }
                    }

                    if (trovato)
                        Console.WriteLine("Numero trovato!");
                    else
                        Console.WriteLine("Numero non presente.");
                }
                else if (scelta != 3)
                {
                    Console.WriteLine("Opzione non valida!");
                }
            } while (scelta != 3);
            Console.WriteLine("Programma terminato.");
        }
    }
}
