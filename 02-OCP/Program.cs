//using _02_OCP.Not_OCP;
using _02_OCP.Applying_OCP;


// Instanciando Not_OCP
//var todoService = new TodoService();
//var todos = await todoService.GetTodoItems();
//foreach (var item in todos)
//{
//    Console.WriteLine(item);
//}
//var postService = new PostService();
//var posts = await postService.getPosts();
//foreach (var item in posts)
//{
//    Console.WriteLine(item);
//}
//var photoService = new PhotoService();
//var photos = await photoService.getPhotos();
//foreach (var item in photos)
//{
//    Console.WriteLine(item);
//}

//Instanciando Applying-OCP
var httpRequester = new HttpRequester();

var todoService = new TodoService(httpRequester);
var todos = await todoService.GetTodoItems();
foreach (var item in todos)
{
    Console.WriteLine(item);
}
var postService = new PostService(httpRequester);
var posts = await postService.GetPosts();
foreach (var post in posts)
{
    Console.WriteLine(post);
}
var photoService = new PhotoService(httpRequester);
var photos = await photoService.GetPhotos();
foreach (var photo in photos)
{
    Console.WriteLine(photo);
}
