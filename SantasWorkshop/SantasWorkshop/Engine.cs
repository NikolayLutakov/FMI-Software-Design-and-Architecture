using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasWorkshop
{
    internal class Engine
    {
        public void Run()
        {
            var santa = new Santa();
            

            var toyFactory = new ToyFactory();
            var storage = new Storage();

            var magicDesk = new MagicDesk();
            var dwarf1 = new Dwarf(toyFactory, storage);
            var dwarf2 = new Dwarf(toyFactory, storage);
            var dwarf3 = new Dwarf(toyFactory, storage);

            var dwarfsList = new List<Dwarf>() { dwarf1, dwarf2, dwarf3 };

            var workShop = new WorkShop(magicDesk, dwarfsList, toyFactory, storage);


            santa.MagicWordsSayed += magicDesk.OnMagicWordsSayed;

            magicDesk.CommandWritten += dwarf1.OnCommandWritten;
            magicDesk.CommandWritten += dwarf2.OnCommandWritten;
            magicDesk.CommandWritten += dwarf3.OnCommandWritten;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("[1] Make Sata say magic words.");
                Console.WriteLine("[2] See toys count in the storage.");
                Console.WriteLine("[0] Exit.");
                Console.WriteLine("Enter numnber");


                var input = Console.ReadLine();
                int number = -1;
                try
                {
                    number = int.Parse(input);
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Only numbers allowed!");
                    Console.WriteLine("Press any key to coninue.");
                    Console.ReadKey();
                    continue;
                }

                switch (number)
                {
                    case 1:
                        MakeSantaSayWords(santa);
                        break;

                    case 2:
                        Console.Clear();
                        workShop.ListToys();
                        Console.WriteLine("Press any key to coninue.");
                        Console.ReadKey();
                        break;
                    case 0:
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid choice number!");
                        Console.WriteLine("Press any key to coninue.");
                        Console.ReadKey();
                        break;
                }
            }          
        }
        private void MakeSantaSayWords(Santa santa)
        {
            Console.Clear();
            Console.WriteLine("Enter 'bicycle' or 'doll'. Enter 'back' for return to main menu.");
            var input = Console.ReadLine();

            if(input == "back")
            {
                return;
            }

            if(input != "bicycle" && input != "doll")
            {
                Console.WriteLine("Invalid input!");
                Console.WriteLine("Press any key to coninue.");
                Console.ReadKey();
                MakeSantaSayWords(santa);
            }

            santa.SayMagicWords(input);
            Console.WriteLine($"Santa sayed 'I need {input}'.");
            Console.WriteLine("Press any key to coninue.");
            Console.ReadKey();
        }
    }
}
