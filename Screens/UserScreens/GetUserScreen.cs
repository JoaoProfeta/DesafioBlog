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
            Console.Clear();
            Console.WriteLine("pegar um usuario usando Email e senha.");
            Console.WriteLine("-------------");
            Console.WriteLine("Digite seu email");
            var email = Console.ReadLine()!;
            Console.WriteLine("Digite sua senha");
            var password = Console.ReadLine()!;
            Console.WriteLine("-------------");
            GetUser(email, password);
            Console.ReadKey();
            MenuUserScreen.Load();
        }
        private static void GetUser(string email, string password)
        {
            var repository = new Repository<User>(DataConn.Connection!);
            var user = repository.Get().FirstOrDefault(x => x.Email == email && x.PasswordHash == password)!;
            Console.WriteLine($"{user.Id} - {user.Name} - {user.Email} - {user.Bio}");
        }
    }
}