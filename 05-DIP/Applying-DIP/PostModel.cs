using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DIP.Applying_DIP
{
    public interface IPost
    {
        int UserId { get; }

        int Id { get; }

        string Title { get; }

        string Body { get; }
    }

    public class Post : IPost
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
