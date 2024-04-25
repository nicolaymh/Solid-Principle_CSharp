using _02_OCP.Not_OCP;


//Instanciando Not_OCP
var todoService = new TodoService();
var todos = await todoService.GetTodoItems();
foreach (var item in todos)
{
    Console.WriteLine(item);
}
var postService = new PostService();
var posts = await postService.getPosts();
foreach (var item in posts)
{
    Console.WriteLine(item);
}
var photoService = new PhotoService();
var photos = await photoService.getPhotos();
foreach (var item in photos)
{
    Console.WriteLine(item);
}

