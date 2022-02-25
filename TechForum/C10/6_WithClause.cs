namespace TechForum.C10
{
    // C# 9
    public record Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

    public class WithClause
    {
        public static void Run()
        {
            var person1 = new Person { FirstName = "Bruno", LastName = "Almeida" };

            var person2 = person1 with { FirstName = "Deliene" };

            Console.WriteLine(person2);
        }
    }
}
