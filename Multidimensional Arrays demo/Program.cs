namespace Multidimensional_Arrays_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] ford = { "Mustang", "F-150", "Explorer" };
            String[] chevy = { "Corvette", "Camaro", "Silverdo" };
            String[] toyota = { "Corolla", "Camry", "Rav4" };
            //This is a mulktidimensional array:
            //it is basic a array of an array
            String[,] parkingLot = 
            { 
                //collum=0,  collum =1, collum=2
                { "Mustang", "F-150", "Explorer" } ,        //row 0
                { "Corvette", "Camaro", "Silverdo" } ,      //row 1
                { "Corolla", "Camry", "Rav4" }              //row 2
            };

            //exampel, I want to change to Explorer, in row 0, colllum 2, to Fusion
            parkingLot[0, 2] = "Fusion";
            parkingLot[2, 0] = "Tacoma";

            foreach(String car in parkingLot)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("");

            //to display as a grit we use nested forloop
            for(int i = 0; i < parkingLot.GetLength(0); i++)
            {
            for(int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i, j] + " ");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}