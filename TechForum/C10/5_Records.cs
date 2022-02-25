namespace TechForum.C10
{
    // C# 9
    public record class RecordPerson
    {
        public RecordPerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string? FirstName { get; init; }
        public string? LastName { get; init; }
    }
    
    public record RecordPersonInline(string FirstName, string LastName);





    // C# 10
    public record struct RecordStructPerson
    {
        public RecordStructPerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }

    public record struct RecordStructPersonInline(string FirstName, string LastName);







    public static class Records
    {
        public static void Run()
        {
            var r = new RecordPerson("Bruno", "Almeida");

            var ri1 = new RecordPersonInline("Bruno", "Almeida");

            var ri2 = new RecordPersonInline("Bruno", "Almeida");
            Console.WriteLine(ri1 == ri2); // TRUE

            var rs = new RecordStructPerson { FirstName = "Bruno", LastName = "Almeida" };
            //rs.LastName = string.Empty;

            var rsi = new RecordStructPersonInline("Bruno", "Almeida");
            rsi.LastName = string.Empty;
        }
    }
}
