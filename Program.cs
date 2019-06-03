using System;
using System.Collections.Generic;
namespace planner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build Your Buildings

            Building NSS = new Building("500 Interstate Blvd")
            {
                Width = 400,
                Depth = 800,
                Stories = 2
            };
            //constructing and purchasing methods
            NSS.Construct();
            NSS.Purchase("Jisie");

            Building Brewery = new Building("132 Marie St")
            {
                Width = 999.20,
                Depth = 600,
                Stories = 1
            };

            //constructing and purchasing methods
            Brewery.Construct();
            Brewery.Purchase("Benjamin");

            Building CoffeeShop = new Building("292 Dickerson Pike")
            {
                Width = 500,
                Depth = 1000.29,
                Stories = 2
            };

            //constructing and purchasing methods
            CoffeeShop.Construct();
            CoffeeShop.Purchase("Ansley");


            //making a new city with the type of City
            City nashvegas = new City("Nashvegas", "Andy", 1867);
            City atlantis = new City("Atlantis", "Jameka", 1593);
            City pangea = new City("Pangea", "Rose", 2019);

            //a list of all my cities!
            List<City> allCities = new List<City>();

            allCities.Add(nashvegas);
            allCities.Add(atlantis);
            allCities.Add(pangea);

            nashvegas.AddABuilding(Brewery);
            nashvegas.AddABuilding(CoffeeShop);
            pangea.AddABuilding(NSS);




            foreach (City city in allCities)
            {
                Console.WriteLine(city.CityName);
                Console.WriteLine($"Established in {city.YearEst}");
                Console.WriteLine($"Mayor name: {city.Mayor}");
                foreach (Building building in city.CityBuildings)
                {
                    Console.WriteLine(building.Address);
                    Console.WriteLine("- - - - - - - - - -");
                    Console.WriteLine($"Designed by {building.Designer}");
                    Console.WriteLine($"Cosnstruced on {building.DateConstructed}");
                    Console.WriteLine($"Owned by {building.Owner}");
                    Console.WriteLine($"{building.Volume} cubic meters of space");
                    Console.WriteLine(" ");
                }
            }
        }

    }
}
