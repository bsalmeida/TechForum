using System.Reflection;

namespace TechForum.NET6
{
    internal class ReflectionNull
    {
        internal static void Run()
        {
            var example = new Example();
            var nullabilityInfoContext = new NullabilityInfoContext();
            foreach (var propertyInfo in example.GetType().GetProperties())
            {
                var nullabilityInfo = nullabilityInfoContext.Create(propertyInfo);
                Console.WriteLine($"{propertyInfo.Name} property is {nullabilityInfo.WriteState}");
            }
        }
    }

    class Example
    {
        public string? Name { get; set; }
        public string Value { get; set; }
    }
}
