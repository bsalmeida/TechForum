namespace TechForum.NET6
{
    internal class MaxBy
    {
        internal static void Run()
        {
            var people = new List<Person>
            {
                new Person
                {
                    Name = "John Smith",
                    Age = 20
                },
                new Person
                {
                    Name = "Jane Smith",
                    Age = 30
                }
            };

            Console.WriteLine(people.MaxBy(x => x.Age)); // 30
            Console.WriteLine(people.OrderByDescending(x => x.Age).First());
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} - Age: {Age}";
        }
    }
}
