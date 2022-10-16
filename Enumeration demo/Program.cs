namespace Enumeration_demo
{
    //enum have to be declared outside of the class but inside the namespace
    //enum Declaration:
    enum DayOfTheWeek
    {
        //values of the enumeration:
        MONDAY,TUESDAY,WEDNESDAY,THURSDAY,FRIDAY,SATURDAY
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //we have created our own data type with the enum
            //aDay is a variable of my enum, and we assign it a valvue with the .MONDAY
            DayOfTheWeek aDay = DayOfTheWeek.MONDAY;

            switch (aDay)
            {
                case DayOfTheWeek.MONDAY:
                    Console.WriteLine("It is monday my dude.");
                    break;
                case DayOfTheWeek.FRIDAY:
                    Console.WriteLine("It is party time my dude");
                    break;
            }
            
            DayOfTheWeek aDay2 = DayOfTheWeek.FRIDAY;

            switch (aDay2)
            {
                case DayOfTheWeek.MONDAY:
                    Console.WriteLine("It is monday my dude.");
                    break;
                case DayOfTheWeek.FRIDAY:
                    Console.WriteLine("It is party time my dude");
                    break;
            }

            Console.ReadLine();
        }
    }
}