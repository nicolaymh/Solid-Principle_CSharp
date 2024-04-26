using System.Net.Http.Json;



namespace _02_OCP.Applying_OCP
{
    /// <summary>
    /// Interfaz para abstraer las operaciones de solicitud HTTP.
    /// </summary>
    public interface IHttpRequester
    {
        Task<IEnumerable<dynamic>> GetItems(string url);
    }

    /// <summary>
    /// Implementación de IHttpRequester utilizando HttpClient.
    /// </summary>
    public class HttpRequester : IHttpRequester
    {
        private readonly HttpClient _httpClient = new HttpClient();

        // Realiza la solicitud HTTP y obtiene los datos como una colección dinámica.
        public async Task<IEnumerable<dynamic>> GetItems(string url)
        {
            var data = await _httpClient.GetFromJsonAsync<IEnumerable<dynamic>>(url);
            return data;
        }
    }

    /// <summary>
    /// Servicio para acceder a los ítems de tipo "TODO".
    /// </summary>
    public class TodoService
    {
        private readonly IHttpRequester _http;

        // Constructor que inyecta la dependencia del objeto que realiza las solicitudes HTTP.
        public TodoService(IHttpRequester http)
        {
            _http = http;
        }

        // Obtiene los ítems TODO de una URL predefinida.
        public async Task<IEnumerable<dynamic>> GetTodoItems()
        {
            var data = await _http.GetItems("https://jsonplaceholder.typicode.com/todos/");
            return data;
        }
    }

    /// <summary>
    /// Servicio para acceder a datos de publicaciones.
    /// </summary>
    public class PostService
    {
        private readonly IHttpRequester _http;

        // Inyección de dependencia del objeto IHttpRequester.
        public PostService(IHttpRequester http)
        {
            _http = http;
        }

        // Obtiene los datos de las publicaciones de una URL predefinida.
        public async Task<IEnumerable<dynamic>> GetPosts()
        {
            var data = await _http.GetItems("https://jsonplaceholder.typicode.com/posts");
            return data;
        }
    }

    /// <summary>
    /// Servicio para acceder a datos de fotografías.
    /// </summary>
    public class PhotoService
    {
        private readonly IHttpRequester _http;

        // Constructor que recibe IHttpRequester para las peticiones HTTP.
        public PhotoService(IHttpRequester http)
        {
            _http = http;
        }

        // Recupera los datos de fotografías de una URL predefinida.
        public async Task<IEnumerable<dynamic>> GetPhotos()
        {
            var data = await _http.GetItems("https://jsonplaceholder.typicode.com/photos");
            return data;
        }
    }

    /*
        Explicación del Principio de Abierto/Cerrado (OCP):

        En la versión anterior del código, cada servicio (TodoService, PostService, PhotoService) 
        creaba y manejaba su propia instancia de HttpClient directamente. Esto implicaba que cualquier 
        cambio en la configuración o en la forma de realizar las solicitudes HTTP requería modificar 
        cada una de las clases de servicio. Por ejemplo, si se necesitaba implementar un manejo de 
        errores personalizado, logging de las peticiones, o cambiar la configuración de los tiempos 
        de espera de las solicitudes, había que hacerlo en múltiples lugares, violando el principio 
        de abierto/cerrado.

        La versión actual del código mejora esta situación utilizando el patrón de inyección de 
        dependencias y la abstracción mediante la interfaz IHttpRequester. Esto permite que los 
        detalles específicos de cómo se realizan las solicitudes HTTP sean manejados por una clase 
        separada (HttpRequester), mientras que las clases de servicio (TodoService, PostService, 
        PhotoService) dependen solo de la abstracción (IHttpRequester). Esto cumple con el principio 
        de abierto/cerrado de la siguiente manera:

        1. Abierto para Extensión: Las clases de servicio son abiertas para extensión porque 
        se pueden introducir cambios en la manera de realizar las solicitudes HTTP (por ejemplo, 
        introduciendo un nuevo método de autenticación o utilizando diferentes bibliotecas de 
        HTTP) simplemente extendiendo o modificando la implementación de HttpRequester o 
        introduciendo una nueva implementación de IHttpRequester sin cambiar las clases de servicio.

        2. Cerrado para Modificación: Las clases de servicio no necesitan ser modificadas cuando 
        cambia la forma en que se realizan las solicitudes HTTP. Esto reduce la necesidad de 
        modificar código existente que ya ha sido probado y verificado, minimizando la posibilidad 
        de introducir errores y simplificando el mantenimiento.
    */
}
