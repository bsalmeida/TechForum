using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace TechForum.NET6
{
    internal static class ParallelForEachAsync
    {
        internal async static Task Run()
        {
            var userHandlers = new[]
{
                "bsalmeida",
                "shanselman",
                "davidfowl"
};

            using HttpClient client = new()
            {
                BaseAddress = new Uri("https://api.github.com/users/"),
            };
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("DotNet", "6"));

            ParallelOptions options = new()
            {
                MaxDegreeOfParallelism = 3
            };
            await Parallel.ForEachAsync(userHandlers, options, async (uri, token) =>
            {
                var user = await client.GetFromJsonAsync<GitHubUser>(uri, token);
                Console.WriteLine($"Name: {user.Name}\nBio: {user.Bio}\n");
            });
        }
    }

    public class GitHubUser
    {
        public string Name { get; set; }
        public string Bio { get; set; }
    }
}
