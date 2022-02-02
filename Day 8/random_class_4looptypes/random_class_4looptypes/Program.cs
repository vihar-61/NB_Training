using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_class_4looptypes
{
    class bikes
    {
        public string bike_model;
        public string bike_brand;
        public int bike_make_year;
        public int bike_powercc;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<bikes> bike = new List<bikes>()
            {
                new bikes(){ bike_model = "Svartpilen 401", bike_brand = "Husqvarna", bike_make_year = 2015, bike_powercc = 375},
                new bikes(){ bike_model = "Duke 250", bike_brand = "KTM", bike_make_year = 2012, bike_powercc = 250},
                new bikes(){ bike_model = "ThunderBird 350x", bike_brand = "Royal Enfield", bike_make_year = 2018, bike_powercc = 350},
                new bikes(){ bike_model = "GS750r", bike_brand = "BMW", bike_make_year = 2016, bike_powercc = 750},
                new bikes(){ bike_model = "Panigale 899", bike_brand = "Ducati", bike_make_year = 2019, bike_powercc = 900},
                new bikes(){ bike_model = "CB500x", bike_brand = "Honda", bike_make_year = 2021, bike_powercc = 500}
            };

            //all bike models----------------------------------------------------------------
            Console.WriteLine("\n------------ All Bike Models ( using for loop ) : ------------\n");
            for (int i = 0; i < bike.Count; i++)
            {
                Console.WriteLine($"Bike model = {bike[i].bike_model}, " +
                                    $"Bike brand = {bike[i].bike_brand}, " +
                                    $"Bike make year = {bike[i].bike_make_year}, " +
                                    $"Bike CC = {bike[i].bike_powercc}");
            }

            //using for loop----------------------------------------------------------------
            Console.WriteLine("\n------------ Bike Models >= 500cc ( using for loop ) : ------------\n");
            for (int i = 0; i < bike.Count; i++)
            {
                if (bike[i].bike_powercc >= 500)
                {
                    Console.WriteLine($"Bike model = {bike[i].bike_model}, " +
                                        $"Bike brand = {bike[i].bike_brand}, " +
                                        $"Bike make year = {bike[i].bike_make_year}, " +
                                        $"Bike CC = {bike[i].bike_powercc}");
                }

            }

            //using foreach loop----------------------------------------------------------------
            Console.WriteLine("\n------------ Bike Models >= 500cc ( using foreach loop ) : ------------\n");
            foreach (var b in bike)
            {
                if(b.bike_powercc >= 500)
                {
                    Console.WriteLine($"Bike model = {b.bike_model}, " +
                                        $"Bike brand = {b.bike_brand}, " +
                                        $"Bike make year = {b.bike_make_year}, " +
                                        $"Bike CC = {b.bike_powercc}");
                }
            }

            //using lambda expression----------------------------------------------------------------
            Console.WriteLine("\n------------ Bike Models >= 500cc ( using lambda exp ) : ------------\n");
            bike.Where(b => b.bike_powercc >= 500).ToList().ForEach(b => Console.WriteLine($"Bike model = {b.bike_model}, " +
                                                                                            $"Bike brand = {b.bike_brand}, " +
                                                                                            $"Bike make year = {b.bike_make_year}, " +
                                                                                            $"Bike CC = {b.bike_powercc}"));

            //using LINQ query----------------------------------------------------------------
            Console.WriteLine("\n------------ Bike Models >= 500cc ( using LINQ ) : ------------\n");
            var output = from b in bike
                         where b.bike_powercc >= 500
                         select b;
            output.ToList().ForEach(b => Console.WriteLine($"Bike model = {b.bike_model}, " +
                                                            $"Bike brand = {b.bike_brand}, " +
                                                            $"Bike make year = {b.bike_make_year}, " +
                                                            $"Bike CC = {b.bike_powercc}"));
            Console.ReadLine();

        }
    }
}
