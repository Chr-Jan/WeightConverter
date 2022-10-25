namespace List_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List:    data structure that represents a list of objects that can be accessed by index.
            //          Similar to array, but can dynamically increase/decrease in size

            //exampel of an array of a fixed size

            Console.WriteLine("Array exampel:");

            String[] food = new string[3];

            food[0] = "pizza";
            food[1] = "hamburger";
            food[2] = "hotdog";

            //I can not add a nother object to the array since it is fixed to 3
            // food[3] = "sushi"; will produce an error

            //To display each element is the array you can use a foreach loop

            foreach(String item in food)
            {
                System.Console.WriteLine(item);
            }

            //The list like to store strings in thise case.

            List<String> foods = new List<string>();

            Console.WriteLine("\nThis is an exampel for List method");

            //to add element to this list "foods" use this method, there is no limit to adding or removing elements:
            //there is no such option in a array

            foods.Add("pizza");
            foods.Add("hambuger");
            foods.Add("hotdog");
            foods.Add("fries");

            //To display each element is the array you can use a foreach loop

            foreach (String item in foods)
            {
                System.Console.WriteLine(item);
            }

            //to access the element in the list, it is like an list, index 0 is pizza

            Console.WriteLine("\nTo access a element in the list:");
            Console.WriteLine(foods[0]);

            //Use this method to insert an element:
            Console.WriteLine("\nThis is an exampel for inserting an element:");

            //You need to insert a index, 0 in this case, and a item:
            foods.Insert(0, "sushi");
            foreach (String item in foods)
            {
                System.Console.WriteLine(item);
            }

            //If you want to remove a element from the list use this method:
            Console.WriteLine("\nExampel for removing from the list:");
            foods.Remove("fries");
            foreach (String item in foods)
            {
                System.Console.WriteLine(item);
            }

            //We can count the size of the list using this method:
            Console.WriteLine("\nThis is an exampel of counting the list:");
            Console.WriteLine(foods.Count);

            //We can find an index of a element like this:
            Console.WriteLine("\nThis is an exampel of finding a index of a element:");
            Console.WriteLine(foods.IndexOf("pizza"));

            //We can check if our list contains a certain element, will return a bollian (true/false):
            Console.WriteLine("\nThis is an exampel of finding an element:");
            Console.WriteLine(foods.Contains("pizza"));

            //We can also sort our list, it will be sorted alphabetically:
            Console.WriteLine("\nThis is an exampel of sorting the list:");
            foods.Sort();
            foreach (String item in foods)
            {
                System.Console.WriteLine(item);
            }
            //Or sorting in reverse alphabetically order:
            foods.Reverse();
            foreach (String item in foods)
            {
                System.Console.WriteLine(item);
            }

            //We can convert out string to an array
            String[] foodsArray = foods.ToArray();

            Console.WriteLine("\nThis is an exampel of converting our list to an array:");
            foreach (String item in foods)
            {
                System.Console.WriteLine(item);
            }

            //We can clear our list
            foods.Clear();

            Console.WriteLine("\nThis is an exampel of clearing our list:");

            foreach (String item in foods)
            {
                System.Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}