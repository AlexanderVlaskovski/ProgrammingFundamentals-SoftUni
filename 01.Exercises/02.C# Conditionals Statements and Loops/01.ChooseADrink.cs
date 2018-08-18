    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace StatementsAndLoopsExercises
    {
        class ChooseADrink
        {
            static void Main(string[] args)
            {
                string Proffesion = Console.ReadLine();

                if (Proffesion == "Athlete")
                    Console.WriteLine("Water");
                else if (Proffesion == "Businessman" || Proffesion == "Businesswoman")
                    Console.WriteLine("Coffee");
                else if (Proffesion == "SoftUni Student")
                    Console.WriteLine("Beer");
                else Console.WriteLine("Tea");
            }
        }
    }
