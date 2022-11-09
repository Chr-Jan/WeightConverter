namespace Multithreading_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // thread = an execution path of a program
            //          We can use multiple threads to perform
            //          different tasks of out program at the same time.
            //          Current thread running is "main" thread
            //          Using System.Threading;

            //this is the main thread
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            //Console.WriteLine(mainThread.Name);

            Console.WriteLine(mainThread.Name + " is complete!");

            //two timers running at the same time
            Thread thread1 = new Thread(CountDown);
            Thread thread2 = new Thread(CountUp);
            thread1.Start();
            thread2.Start();

            //invoking method
            CountDown();
            CountUp();

            Console.WriteLine(mainThread.Name + "is complete!");

            Console.ReadKey();
        }

        //method
        //string name not neccesary
        public static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"Timer #1: {i} seconds");
                //1000 = 1000 miliseconds or 1 second
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is complete!");
        }
        //method
        //string name not neccesary
        public static void CountUp()
        {
            for (int i = 0; i <= 10; i ++)
            {
                Console.WriteLine($"Timer #2: {i} seconds");
                //1000 = 1000 miliseconds or 1 second
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete!");
        }
    }
}