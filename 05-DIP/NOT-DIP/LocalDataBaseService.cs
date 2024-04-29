
namespace _05_DIP.NOT_DIP
{
    public class LocalDataBaseService
    {
        public LocalDataBaseService() { }

        public async Task<List<dynamic>> GetFakePosts()
        {
            return await Task.FromResult(new List<dynamic>
            {
                new
                {
                    UserId = 1,
                    Id = 1,
                    Title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
                    Body = "quia et suscipit suscipit recusandae consequuntur expedita et cum reprehenderit molestiae ut ut quas totam nostrum rerum est autem sunt rem eveniet architecto"
                },
                new
                {
                    UserId = 1,
                    Id = 2,
                    Title = "qui est esse",
                    Body = "est rerum tempore vitae sequi sint nihil reprehenderit dolor beatae ea dolores neque fugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis qui aperiam non debitis possimus qui neque nisi nulla"
                }
            });
        }
    }
}
