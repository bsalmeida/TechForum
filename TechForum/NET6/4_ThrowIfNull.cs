namespace TechForum.NET6
{
    internal static class ThrowIfNull
    {
        internal static void Run()
        {
            ExampleMethod(null);

            void ExampleMethod(object param)
            {
                if (param == null)
                {
                    throw new ArgumentNullException(nameof(param));
                }

                // Do something
            }























            void ExampleMethod2(object param)
            {
                ArgumentNullException.ThrowIfNull(param);

                // Do something
            }
        }
    }
}
