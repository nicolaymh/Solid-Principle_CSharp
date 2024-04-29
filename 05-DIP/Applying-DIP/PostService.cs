using _05_DIP.NOT_DIP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DIP.Applying_DIP
{
    public class PostService
    {
        private List<IPost> _posts = new List<IPost>();
        private IPostProvider _postProvider;

        public PostService(IPostProvider postProvider)
        {
            _postProvider = postProvider;
        }

        public async Task<List<IPost>> GetPosts()
        {
            _posts = await _postProvider.GetPosts();

            return _posts;
        }
    }
}
