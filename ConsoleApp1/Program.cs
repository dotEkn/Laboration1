using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variablar för namn och ålder för 4 personer! (Ändrar du på [4] till t.ex [6] så blir det 6 personer/åldrar i strängarna!)
            string[] namn = new string[4];
            int[] ålder = new int[4];

            // Användaren får själv skriva in namn och åldrar för varje person!
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Skriv namn på en person " + (i + 1) + ": ");
                namn[i] = Console.ReadLine();

                Console.WriteLine("Skriv ålder för " + namn[i] + ": ");
                if (int.TryParse(Console.ReadLine(), out ålder[i]) == false)
                {
                    // Om det är en ogiltig ålder, så får den försöka igen för samma person.
                    Console.WriteLine("Var snäll och ange ett heltal.");
                    i--;
                }
            }
            // Skriver ut namn och åldrarna på  alla personer så att användaren får se vad den har skrivit.
            Console.WriteLine("Namn och ålder på personer:");
            for (int i = 0; i < 4; i++)
            {
            Console.WriteLine(namn[i] + " är " + ålder[i] + " år gammal.");
            }
            // Summan på åldrarna!
            int summaåld = ålder[0] + ålder[1] + ålder[2] + ålder[3];
            Console.WriteLine("Summa av åldrarna: " + summaåld);

            // Medelåldern med två decimaler!
            double medelåld = (double)summaåld / 4;
            Console.WriteLine("Medelålder: " + medelåld.ToString("F2"));
        }

    }
}
