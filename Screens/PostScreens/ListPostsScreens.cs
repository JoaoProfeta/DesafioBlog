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
            Console.WriteLine("-------------------------------");
            GetAll(userLogg);
            Console.ReadKey();
            MenuPostScreen.Load();

        }
        private static void GetAll(User user)
        {
            //var repository = new Repository<User>(DataConn.Connection!);
            var repository = new PostRepository(DataConn.Connection!);
            var repo = new Repository<Category>(DataConn.Connection!);
            var posts = repository.GetPostsByAuthorId(user.Id);
            var categorias = repo.Get().ToList();
            foreach (var item in posts)
            {
                var selectCat = categorias.Find(x => x.Id == item.CategoryId);
                Console.WriteLine("-------------------------------");
                Console.WriteLine($"{item?.AuthorId} -{selectCat?.Name} - {item?.Title}");
                Console.WriteLine("-------------------------------");

            }
        }
    }
}