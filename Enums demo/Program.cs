namespace Enums_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // enums =  special "class" that contains a set of named integer constants.
            //          Use enums when you have values that you know will not change,
            //          To get the integer value from an item, you must explicitly convert to an int

            //          name = integer

            //name of the enum "Planets" and name of the named member "Pluto"
            Console.WriteLine(Planets.Pluto + " is a planet");
            Console.WriteLine(Planets.Mercury + " is planet number" + (int)Planets.Mercury);

            double volume = Volume(PlanetRaduis.Earth);

            //variable to store planets
            string name = PlanetRaduis.Earth.ToString();
            int radius = (int)PlanetRaduis.Earth;

            Console.WriteLine("Planets: " + name);
            Console.WriteLine("Radius " + radius + " km");
            Console.WriteLine("Volume: " + volume + " km^3");

            Console.ReadKey();
        }
        public static double Volume(PlanetRaduis radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }
    }
    enum Planets
    {
        Mercury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4, 
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7,
        Neptune = 8,
        Pluto = 9
    }
    enum PlanetRaduis
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }
}