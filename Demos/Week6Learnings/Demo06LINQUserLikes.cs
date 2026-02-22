namespace Week6Learnings
{
    class User { public int Id; public string Name; public string Country; }
    class Post { public int UserId; public int Likes; }

    internal class Demo06LINQUserLikes
    {
        static void Main(string[] args)
        {
            var users = new List<User>
                {
                    new User{Id=1, Name="A", Country="India"},
                    new User{Id=2, Name="B", Country="USA"}
                };

            var posts = new List<Post>
                {
                    new Post{UserId=1, Likes=100},
                    new Post{UserId=1, Likes=50}
                };


          

            var inactive = users.GroupJoin(posts,
                u => u.Id, p => p.UserId,
                (u, p) => new { Name = u.Name, HasLikes = p.Any() }
                );

            foreach (var u in inactive)
            {
                Console.WriteLine(u.Name + " " + u.HasLikes);
            }

        }
    }
}
