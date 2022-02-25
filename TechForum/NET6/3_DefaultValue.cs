namespace TechForum.NET6
{
    internal class DefaultValue
    {
        internal static void Run()
        {
            //var list = new List<int> { 0, 1, 2, 2 };
            //var value = 0;
            //var foundValue = list.FirstOrDefault(x => x == value);
            //if (foundValue == default)
            //{
            //    Console.WriteLine("Not found!");
            //}
            //else
            //{
            //    Console.WriteLine("Found!");
            //}






















            var list = new List<int> { 0, 1, 2, 2 };
            var value = 0;
            const int defaultValue = -1;
            var foundValue = list.FirstOrDefault(x => x == value, defaultValue);
            if (foundValue == defaultValue)
            {
                Console.WriteLine("Not found!");
            }
            else
            {
                Console.WriteLine("Found!");
            }
        }
    }
}
