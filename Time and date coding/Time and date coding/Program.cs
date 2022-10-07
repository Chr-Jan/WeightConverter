namespace Time_and_date_coding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;

            Console.WriteLine(myValue.ToString());
            Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToLongTimeString());

            //Here you can add time to your current date

            //3 days have been added to the current date
            Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //3 hours have been added to the current date
            Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            //3 days have been substracted to the current date
            Console.WriteLine(myValue.AddDays(-3).ToShortDateString());
            //Will show the current month in number
            Console.WriteLine(myValue.Month.ToString());

            //Write my birthday and make it into a DateTime instance
            DateTime myBirthday = new DateTime(1987, 1, 16);
            Console.WriteLine(myBirthday.ToShortDateString());

            //Total days I have been alive
            DateTime myBirthday2 = DateTime.Parse("16/1/1987");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday2);
            Console.WriteLine(myAge.TotalDays);

            string[] months = {"January", "February", "March", "April", "May",
    "June", "July", "August", "September", "October", "November", "December"};


            //DateTime represents an instant in time. Its properties provide various aspects of the date and time.
            DateTime now = DateTime.Now;

            Console.WriteLine("Today's date: {0}", now.Date);
            Console.WriteLine("Today is {0} day of {1}", now.Day, months[now.Month - 1]);
            Console.WriteLine("Today is {0} day of {1}", now.DayOfYear, now.Year);
            Console.WriteLine("Today's time: {0}", now.TimeOfDay);
            Console.WriteLine("Hour: {0}", now.Hour);
            Console.WriteLine("Minute: {0}", now.Minute);
            Console.WriteLine("Second: {0}", now.Second);
            Console.WriteLine("Millisecond: {0}", now.Millisecond);
            Console.WriteLine("The day of week: {0}", now.DayOfWeek);
            //The Kind property returns a value that indicates whether the time represented by this DateTime instance is based on local time, Coordinated Universal Time (UTC), or neither.
            Console.WriteLine("Kind: {0}", now.Kind);


            Console.ReadLine();
        }
    }
}