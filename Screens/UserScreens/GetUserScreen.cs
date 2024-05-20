using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class GetUserScreen
    {
        public static void Load()
        {
            var user = UserLogged.logged;

            Console.Clear();
            Console.WriteLine("Veja suas informações");
            Console.WriteLine("-------------");
            GetUser(user);
            Console.ReadKey();
            MenuUserScreen.Load();
        }
        private static void GetUser(User userLogg)
        {
            var repository = new Repository<User>(DataConn.Connection!);
            var user = repository.Get().FirstOrDefault(x => x.Email == userLogg.Email && x.PasswordHash == userLogg.PasswordHash)!;

            Console.WriteLine($"{user.Id} - {user.Name} - {user.Email} - {user.Bio} - {user.Image}");
            var getUserPosts = new PostRepository(DataConn.Connection!);

            Console.WriteLine("Posts: ");
            Console.WriteLine();
            var posts = getUserPosts.GetPostsByAuthorId(user.Id);
            foreach (var post in posts)
            {
                Console.Write($" Id :{post.Id} \n Titulo: {post.Title} \n Categoria: {post.CategoryId} \n Data de criação: {post.CreateDate} \n Data da ultima atualização: {post.LastUpdateDate}");
            }

        }
    }
}