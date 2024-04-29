

namespace _05_DIP.Applying_DIP
{
    /// <summary>
    /// Define la interfaz para una estructura de Post, abstrayendo los detalles del post
    /// para que las implementaciones puedan variar sin afectar a los consumidores de la interfaz.
    /// </summary>
    public interface IPost
    {
        int UserId { get; }

        int Id { get; }

        string Title { get; }

        string Body { get; }
    }



    /// <summary>
    /// Implementación concreta de IPost, proporciona una representación básica de un post
    /// que incluye UserId, Id, Title y Body.
    /// </summary>
    public class Post : IPost
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
