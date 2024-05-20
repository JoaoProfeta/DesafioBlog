using System;
using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog.Screens.PostScreens
{

    public static class ListPostsScreen
    {

        public static void Load(User userLogg)
        {
            Console.Clear();
            Console.WriteLine($"Lista de Posts do usuário : {userLogg.Name}");
            Console.WriteLine("-------------");
            GetAll(userLogg);
            Console.ReadKey();
            MenuPostScreen.Load();

        }
        private static void GetAll(User user)
        {
            //var repository = new Repository<User>(DataConn.Connection!);
            var thisback = new PostRepository(DataConn.Connection!);
            var posts = thisback.GetPostsByAuthorId(user.Id);

            foreach (var item in posts)
            {
                Console.WriteLine($"{item.AuthorId} - {item.Title}");
            }
        }
    }
}