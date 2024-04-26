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

// Violacion principio OCP abierto y cerrado:
// Las clases de servicio actuales violan el principio de abierto y cerrado (OCP) ya que están altamente acopladas
// con la implementación específica de HttpClient y el manejo directo de las URLs dentro de los métodos de cada clase.
// Esto no solo dificulta la extensión de estas clases sin modificar su código interno (por ejemplo, cambiar el
// comportamiento de las solicitudes HTTP o ajustar la lógica de manejo de URLs), sino que también introduce
// problemas de duplicación de código y manejo de recursos. Idealmente, las clases deberían diseñarse para permitir
// la inyección de dependencias, como la fuente de datos y el cliente HTTP, y encapsular mejor las variaciones
// en las peticiones HTTP y la configuración de URL para cumplir con el OCP, facilitando así su extensión y mantenimiento.
