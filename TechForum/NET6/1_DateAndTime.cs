namespace TechForum.NET6
{
    internal static class DateAndTime
    {
        internal static void Run()
        {
            DateOnly dateOnly = new(2021, 9, 25);
            Console.WriteLine(dateOnly);

            TimeOnly timeOnly = new(19, 12, 25);
            Console.WriteLine(timeOnly);

            DateOnly dateOnlyFromDate = DateOnly.FromDateTime(DateTime.Now);
            Console.WriteLine(dateOnlyFromDate);

            TimeOnly timeOnlyFromDate = TimeOnly.FromDateTime(DateTime.Now);
            Console.WriteLine(timeOnlyFromDate);
        }
    }
}
