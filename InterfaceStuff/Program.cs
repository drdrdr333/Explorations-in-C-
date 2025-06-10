using InterfaceStuff;

namespace InterfaceStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Just for fun
            int counter = 10;
            int track = 0;

            Cat c = new Cat();
            Console.WriteLine($"New cat -> {c.Name} {c.Type} {c.DateDiscovered}");
            Dog d = new Dog();
            Console.WriteLine($"New dog -> {d.IsPet} {d.Type} {d.Type}");

            List<IAnmial> interfaceAnimalList = new List<IAnmial>();
            while (track < counter) {
                Cat cat = new Cat(track, track + 1, "Feline", $"Cat number {track}");
                Dog dog = new Dog(track, track + 1, "Canine", $"Dog number {track}");
                interfaceAnimalList.Add(cat);
                interfaceAnimalList.Add(dog);
                track++;
            }

            foreach (IAnmial a in interfaceAnimalList) {
                if (a is Cat theCat) {
                    Console.WriteLine($"The {theCat.Type} is a {theCat.Description} and has {theCat.NumberOfLegs} legs and has a name {theCat.Name}");
                }
                if (a is Dog theDog) {
                    Console.WriteLine($"The {theDog.Type} is a {theDog.Description} and has {theDog.NumberOfLegs} legs and has a name {theDog.Name}");
                }
            }
            
        }
    }
}
