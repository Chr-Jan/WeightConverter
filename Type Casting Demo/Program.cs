namespace Type_Casting_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Type casting =  Converting a value to a different data type. Useful when we accept user input (string).
            //                  Different data types can do different things.

            //we convert a double a into a int by using Convert.ToInt32() method.
            double a = 3.14;
            int b = Convert.ToInt32(a);

            Console.WriteLine(a);
            //b is a int now and will only show 3
            Console.WriteLine(b);

            //we can also use the get type method.
            //GetType() will show what data type "a" is.
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());

            //Now we are converting a int to a double
            int c = 123;
            //you can also add exampel "+ 0.1" to add more to the converted int that is a double.
            double d = Convert.ToDouble(c) + 0.1;
            Console.WriteLine(d.GetType());
            Console.WriteLine(d);

            //Converting a int to a string
            int e = 312;
            String f = Convert.ToString(e);
            Console.WriteLine(f.GetType());
            Console.WriteLine(f);

            //Converting a String to a char
            String g = "$";
            char h = Convert.ToChar(g);
            Console.WriteLine(h.GetType());
            Console.WriteLine(h);

            //Convert String to boolean
            String i = "true";
            bool j = Convert.ToBoolean(i);
            Console.WriteLine(j.GetType());
            Console.WriteLine(j);

            Console.ReadKey();
        }
    }
}