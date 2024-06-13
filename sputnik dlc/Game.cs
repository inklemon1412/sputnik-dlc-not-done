using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace sputnik_dlc
{
    internal class Game
    {
        private bool hasBalltre = false;
        private bool hasPrince = false;
        private bool hasWånderbævm = false;
        public CharacterCreator Creator { get; set; }
        public Car car { get; set; }
        public void MainGame()
        {
            bool choose = true;
            while (choose)
            {
                Console.WriteLine("Welcome to the pin collection game");
                Console.WriteLine("First you need to choose your cruch");
                Console.WriteLine("1. Balltre med glitter - reduserer pins pris\n2. Pins Prins - ekstra pin\n3. Wånderbævm i Ruta - ekstra bensin");
                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        hasBalltre = true;
                        choose = false;
                        break;
                    case "2":
                        hasPrince = true;
                        choose = false;
                        break;
                    case "3":
                        hasWånderbævm = true;
                        choose = false;
                        break;
                    default:
                        Console.WriteLine("Hei idiot! Du må jo skrive et tall!");
                        break;
                }
            }

            while (hasBalltre == true)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Kjør til neste Bensinstasjon\n2. Sjekk Cowboyhatten for pins\n3. Kjøp pins" +
                "\n4. Opptre på nåværende bensinstasjon for penger\n5. Kjøp bensin");
                var choiceInput = Console.ReadLine();
                switch (choiceInput)
                {
                    case "1":
                        KjørVidere();
                        break;
                }

            }

        }


    }
}


