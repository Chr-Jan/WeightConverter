namespace String_Methods_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String fullName = "Chris Code";
            String phoneNumber = "123-456-7890";
            String phoneNumber2 = "123-456-7890";


            fullName = fullName.ToUpper();
            Console.WriteLine(fullName);

            fullName = fullName.ToLower();
            Console.WriteLine(fullName);

            //we use .Replace property to remove one char and replace it with another
            //here we replace the symbol - and replace it with /
            phoneNumber = phoneNumber.Replace("-", "/");
            Console.WriteLine(phoneNumber);
            //or we can use this to just remove a symbol
            phoneNumber2 = phoneNumber2.Replace("-", "");
            Console.WriteLine(phoneNumber2);

            //We can insert a symbol using the .Insert property 
            //here i use my fullName and insert a @ at the start, since 0 is the start
            String userName = fullName.Insert(0, "@");
            Console.WriteLine(userName);

            //the .Length proberty show how long a string is.
            Console.WriteLine(fullName.Length);

            //the substring method
            String firstName = fullName.Substring(0, 5);
            String lastName = fullName.Substring(5);
            Console.WriteLine(firstName + lastName);

            Console.ReadKey();
        }
    }
}