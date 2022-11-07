namespace Lists_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List =   data structure that represent a list of objects that can be accessed by index.
            //          Similar to array, but dunamically increase/decrease in size
            //          using System.Collections.Generic;

            //array, size 3
            //string[] food = new string[3];

            //food[0] = "pizza";
            //food[1] = "hamburger";
            //food[2] = "hotdog";

            //foreach(string foodItem in food)
            //{
            //    Console.WriteLine(foodItem);
            //}

            //declare named food list
            List<string> food = new List<string>();

            //adding to the list, use .Add()
            food.Add("fries");
            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");

            //remove from a list:
            food.Remove("fries");

            //inserting an element at a index:
            //index 0 insert sushi
            food.Insert(0, "sushi");

            //the size of the list:
            Console.WriteLine(food.Count);

            //finding a index of a element
            Console.WriteLine(food.IndexOf("pizza"));

            //finding the last index
            Console.WriteLine(food.LastIndexOf("fries"));

            //finding a certain item (boolean)
            Console.WriteLine(food.Contains("pizza"));

            //sorting in order
            food.Sort();

            //sorting reverse order
            food.Reverse();


            foreach (string foodItem in food)
            {
                Console.WriteLine(foodItem);
            }

            //to access an list:
            Console.WriteLine(food[0]);

            //clear list
            food.Clear();

            //convert list to array
            string[] foodArray = food.ToArray();

            Console.ReadKey();
        }
    }
}