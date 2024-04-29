//using _05_DIP.NOT_DIP;
using _05_DIP.Applying_DIP;


// Instanciando Not-DIP:
//var postService = new PostService();
//var posts = await postService.GetPosts();
//foreach (var post in posts)
//{
//    Console.WriteLine("Post ID:".PadRight(10) + post.Id.ToString());
//    Console.WriteLine("User ID:".PadRight(10) + post.UserId.ToString());
//    Console.WriteLine("Title:".PadRight(10) + post.Title);
//    Console.WriteLine("Body:".PadRight(10) + post.Body);
//    Console.WriteLine(); // Línea en blanco para separar cada post
//}


// Instanciando Applying-DIP:

/// <summary>
/// Punto de entrada principal para la aplicación de consola.
/// Este ejemplo ilustra la implementación del Principio de Inversión de Dependencias (DIP),
/// que permite una fácil sustitución entre diferentes fuentes de datos, como WebApiPostService y LocalDataBaseService.
/// Gracias a la inyección de dependencias, PostService puede operar con cualquier implementación de IPostProvider,
/// demostrando una alta flexibilidad y desacoplamiento de componentes. Esto facilita el mantenimiento y la escalabilidad del código.
/// </summary>
var localDataBaseService = new LocalDataBaseService();

var client = new HttpClient();
var webApiPostService = new WebApiPostservice(client);

var postService = new PostService(webApiPostService);
var posts = await postService.GetPosts();
foreach (var post in posts)
{
    Console.WriteLine("Post ID:".PadRight(10) + post.Id.ToString());
    Console.WriteLine("User ID:".PadRight(10) + post.UserId.ToString());
    Console.WriteLine("Title:".PadRight(10) + post.Title);
    Console.WriteLine("Body:".PadRight(10) + post.Body);
    Console.WriteLine(); // Línea en blanco para separar cada post
}