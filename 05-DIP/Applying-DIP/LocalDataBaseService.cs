using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace _05_DIP.Applying_DIP
{

    public interface IPostProvider
    {
        public Task<List<IPost>> GetPosts();
    }


    public class LocalDataBaseService : IPostProvider
    {
        public LocalDataBaseService() { }

        public async Task<List<IPost>> GetPosts()
        {
            return await Task.FromResult(new List<IPost>
            {
                new Post
                {
                    UserId = 1,
                    Id = 1,
                    Title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
                    Body = "quia et suscipit suscipit recusandae consequuntur expedita et cum reprehenderit molestiae ut ut quas totam nostrum rerum est autem sunt rem eveniet architecto"
                },
                new Post
                {
                    UserId = 1,
                    Id = 2,
                    Title = "qui est esse",
                    Body = "est rerum tempore vitae sequi sint nihil reprehenderit dolor beatae ea dolores neque fugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis qui aperiam non debitis possimus qui neque nisi nulla"
                }
            });
        }
    }


    public class WebApiPostservice : IPostProvider
    {
        private readonly HttpClient _httpClient;

        public WebApiPostservice(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<IPost>> GetPosts()
        {
            var url = "https://jsonplaceholder.typicode.com/posts";

            try
            {
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var jsonString = await response.Content.ReadAsStringAsync();

                var posts = JsonSerializer.Deserialize<List<Post>>(jsonString, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });

                if (posts == null)
                    return new List<IPost>();

                return posts.ConvertAll(p => (IPost)p);

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error retrieving data: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }

            return new List<IPost>();
        }
    }
}
