using System;
using System.Collections.Generic;


namespace planner
{
    public class City
    {
        // Name of the city.
        public string CityName { get; set; }
        // The mayor of the city.
        public string Mayor { get; set; }

        // Year the city was established.
        public int YearEst { get; set; }

        // A collection of all of the buildings in the city.
        public List<Building> CityBuildings { get; set; } = new List<Building>();

        // A method to add a building to the city.
        public void AddABuilding(Building building)
        {
            CityBuildings.Add(building);
        }

        //constructor to make a city
        public City(string cityName, string mayor, int year)
        {
            CityName = cityName;
            Mayor = mayor;
            YearEst = year;

        }

    }
}