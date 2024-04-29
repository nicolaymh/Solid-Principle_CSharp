using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace _05_DIP.Applying_DIP
{
    /// <summary>
    /// Define una interfaz para obtener posts, permitiendo que la implementación subyacente
    /// varíe (p.ej., desde una base de datos local o un servicio web) sin impactar a los consumidores.
    /// Esto facilita la adherencia al Principio de Inversión de Dependencias (DIP).
    /// </summary>
    public interface IPostProvider
    {
        public Task<List<IPost>> GetPosts();
    }


    /// <summary>
    /// Proveedor de posts que recupera datos desde una base de datos local simulada.
    /// Implementa IPostProvider y devuelve una lista estática de posts.
    /// </summary>
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

    /// <summary>
    /// Proveedor de posts que obtiene datos desde una API web externa.
    /// Implementa IPostProvider y utiliza HttpClient para recuperar y deserializar los posts desde una URL especificada.
    /// </summary>
    public class WebApiPostservice : IPostProvider
    {

        // Campo para almacenar la instancia de HttpClient usada para las solicitudes HTTP.
        private readonly HttpClient _httpClient;

        // Constructor que asigna el HttpClient proporcionado al campo interno.
        public WebApiPostservice(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Método asincrónico que obtiene una lista de posts desde un endpoint de API.
        public async Task<List<IPost>> GetPosts()
        {

            // URL del endpoint API desde donde se obtendrán los posts.
            var url = "https://jsonplaceholder.typicode.com/posts";

            try
            {
                // Realiza una solicitud GET a la URL y espera por la respuesta.
                var response = await _httpClient.GetAsync(url);

                // Verifica que la respuesta HTTP sea exitosa, de lo contrario lanza una excepción.
                response.EnsureSuccessStatusCode();

                // Lee el contenido de la respuesta como una cadena JSON.
                var jsonString = await response.Content.ReadAsStringAsync();

                // Deserializa la cadena JSON a una lista de objetos Post con ajuste a camelCase para los nombres de propiedades.
                var posts = JsonSerializer.Deserialize<List<Post>>(jsonString, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });

                // Si la deserialización retorna null, devuelve una lista vacía.
                if (posts == null)
                {
                    return new List<IPost>();
                }

                // Convierte la lista de Post a una lista de IPost y la devuelve.
                return posts.ConvertAll(p => (IPost)p);

            }

            // Captura y maneja errores específicos de la solicitud HTTP.
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error retrieving data: {e.Message}");
            }

            // Captura y maneja cualquier otro tipo de error no esperado.
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }

            // Devuelve una lista vacía en caso de errores.
            return new List<IPost>();
        }
    }
}
