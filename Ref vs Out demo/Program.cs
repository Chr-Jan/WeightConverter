namespace Ref_vs_Out_demo
{
    // C# program to illustrate the
    // concept of out parameter
    using System;

    class Program
    {

        // Main method
        static public void Main()
        {
            // Create  struct instance and initialize by using "new".
            // The code in both Ref and Out, have ben written to write both examples, which is why we dont need "Console.WriteLine();" here.
            RefDemo refDemo = new RefDemo();

            OutDemo outDemo = new OutDemo();

        }

    }
}