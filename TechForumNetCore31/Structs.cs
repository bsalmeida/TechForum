namespace TechForumNetCore31
{
    public struct Address
    {
        public Address(string city)
        {
            City = city;
        }

        public string City { get; set; }
    }

    public struct Address2
    {
        public string City { get; set; }
    }

}
