using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sputnik_dlc
{
    internal class Kjør
    {
        public static void KjørVidere()
        {

            var pinstorage = new PinStorage();

            pinstorage.AddPin(new BilligPins("Regnbuen", 50));
            pinstorage.AddPin(new BilligPins("Bien", 20));
            pinstorage.AddPin(new BilligPins("Acen", 100));
            pinstorage.AddPin(new BilligPins("Pannen", 10));

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Du har endt opp ved kubrua bensinstasjon");
                Console.WriteLine("Tast 1-4 for å kjøpe en pin =)");
                var userInput = Console.ReadLine();

                if (userInput == "1") 
                {
                    Console.WriteLine("Du har kjøpt regbuen");
                }

            }

        }
    }
}
