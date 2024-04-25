using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Json;
using System.Text.Json;


namespace _02_OCP.Not_OCP
{

    public class TodoService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<IEnumerable<dynamic>> GetTodoItems()
        {
            var data = await _httpClient.GetFromJsonAsync<IEnumerable<dynamic>>("https://jsonplaceholder.typicode.com/todos/");

            return data;
        }
    }

    public class PostService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<IEnumerable<dynamic>> getPosts()
        {
            var data = await _httpClient.GetFromJsonAsync<IEnumerable<dynamic>>("https://jsonplaceholder.typicode.com/posts");

            return data;
        }
    }

    public class PhotoService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<IEnumerable<dynamic>> getPhotos()
        {
            var data = await _httpClient.GetFromJsonAsync<IEnumerable<dynamic>>("https://jsonplaceholder.typicode.com/photos");

            return data;
        }
    }
}
