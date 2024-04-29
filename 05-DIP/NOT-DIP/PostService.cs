

namespace _05_DIP.NOT_DIP
{
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
