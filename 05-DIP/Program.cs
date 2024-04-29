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
var localDataBaseService = new LocalDataBaseService();

var client = new HttpClient();
var webApiPostService = new WebApiPostservice(client);

var postService = new PostService(localDataBaseService);
var posts = await postService.GetPosts();
foreach (var post in posts)
{
    Console.WriteLine("Post ID:".PadRight(10) + post.Id.ToString());
    Console.WriteLine("User ID:".PadRight(10) + post.UserId.ToString());
    Console.WriteLine("Title:".PadRight(10) + post.Title);
    Console.WriteLine("Body:".PadRight(10) + post.Body);
    Console.WriteLine(); // Línea en blanco para separar cada post
}