namespace TechForum.C10
{
    internal class InferredDelegateType
    {
        public InferredDelegateType()
        {
            // C# 9
            Func<string, int> parse = (string s) => int.Parse(s);

            // C# 10
            var parse2 = (string s) => int.Parse(s);

            //var parse = s => int.Parse(s); // ERROR: Not enough type info in the lambda
        }
    }
}
