using Inheritance;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a construct to iterate
            List<Building> listOfBuildings = new List<Building>();

            Building b1 = new Building("Waldorf", "111 Hello Street");
            Building b2 = new Building("Building 2", "123 new building");

            House h1 = new House(1, 5, 3, "house 1 - b1", "111 new house");
            House h2 = new House(2, 6, 3, "house 2 - b2", "111 new house");

            // type cast to base
            // Virtual table overrides the building implementation of ToString()!
            // Building b3 = h1 as Building;
            Store st1 = new Store();
            Store st2 = new Store(2, 7, "Candles", "Candle Store");

            listOfBuildings.Add(b1);
            listOfBuildings.Add(b2);
            listOfBuildings.Add(h1);
            listOfBuildings.Add(h2);
            listOfBuildings.Add(st1);
            listOfBuildings.Add(st2);
            string seperator = new string('=', 100);

            foreach (Building b in listOfBuildings) {
                Console.WriteLine(seperator);
                if (b is House) { 
                    House house = (House) b;
                    Console.WriteLine($"This is a house {house} all attributes (will be the base!) {house.PrintAllAttributes()}");
                    continue;
                }
                if (b is Store)
                {
                    Store store = (Store) b;
                    Console.WriteLine($"This is a store {store} all attributes (will be polymorphed) {store.PrintAllAttributes()}");
                    continue;
                }
                Console.WriteLine($"This is a building {b}");
            }
        }
    }
}
