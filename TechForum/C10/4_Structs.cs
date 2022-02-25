namespace TechForum.C10
{
    public struct Address1
    {
        // Parameterless constructor
        public Address1()
        {
            City = "<unknown>";
        }

        public string City { get; set; }
    }

    public struct Address3
    {
        // Field initializer
        public string City { get; set; } = "<unknown>";
    }
}
