

namespace _05_DIP.NOT_DIP
{

    /// <summary>
    /// Violaciones del Principio de Inversión de Dependencias (DIP):
    /// 
    /// 1. Dependencia Directa sobre Implementaciones Concretas:
    ///    PostService depende directamente de la clase concreta LocalDataBaseService en lugar de una abstracción.
    ///    Esto limita la flexibilidad del código, haciendo difícil su modificación y extensión sin alterar PostService.
    ///
    /// 2. Creación de Instancias de Bajo Nivel dentro de una Clase de Alto Nivel:
    ///    PostService crea una instancia de LocalDataBaseService directamente en su método GetPosts(), lo cual 
    ///    aumenta el acoplamiento y dificulta la realización de pruebas unitarias aisladas. Según el DIP, las clases
    ///    de alto nivel no deberían crear instancias de clases de bajo nivel, sino más bien trabajar con abstracciones.
    ///
    /// Estas prácticas resultan en un alto acoplamiento y baja cohesión, reduciendo la capacidad de mantener y escalar 
    /// el sistema efectivamente.
    /// </summary>

    public class PostService
    {
        private List<dynamic> _posts = new List<dynamic>();

        public PostService() { }

        public async Task<List<dynamic>> GetPosts()
        {
            var service = new LocalDataBaseService();
            _posts = await service.GetFakePosts();

            return _posts;
        }
    }
}
