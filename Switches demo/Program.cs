namespace Switches_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //switch = an efficient alternative to many else if statements

            //we can rewrite following code for a swtich

            Console.WriteLine("What day is it today?");
            String day = Console.ReadLine();
                                  
            //if(day == "Monday")
            //{
            //    Console.WriteLine("It's Monday!");
            //}
            //else if (day == "Tuesday")
            //{
            //    Console.WriteLine("It's Tuesday!");
            //}
            //else if (day == "Wednesday")
            //{
            //    Console.WriteLine("It's Wednesday!");
            //}
            //else if (day == "Thursday")
            //{
            //    Console.WriteLine("It's Thursday!");
            //}
            //else if (day == "Friday")
            //{
            //    Console.WriteLine("It's Friday!");
            //}
            //else if (day == "Saturday")
            //{
            //    Console.WriteLine("It's Saturday!");
            //}
            //else if (day == "Sunday")
            //{
            //    Console.WriteLine("It's Sunday!");
            //}
            //else
            //{
            //    Console.WriteLine($"{day} is not a day");
            //}

            switch(day)
            {
                case "Monday":
                    Console.WriteLine("It's Monday!");
                    break;
                case "Tuesday":
                    Console.WriteLine("It's Tuesday!");
                    break;
                case "Wednesday":
                    Console.WriteLine("It's Wednesday!");
                    break;
                case "Thursday":
                    Console.WriteLine("It's Thursday");
                    break;
                case "Friday":
                    Console.WriteLine("It's Friday");
                    break;
                case "Saturday":
                    Console.WriteLine("It's Saturday!");
                    break;
                case "Sunday":
                    Console.WriteLine("It's Sunday!");
                    break;
                //default is used if non of the cases is correctly writting
                default:
                    Console.WriteLine($"{day} is not a day");
                    break;

            }

            Console.ReadKey();
        }
    }
}