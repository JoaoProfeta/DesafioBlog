using System;
using Blog.Models;
using Blog.Repositories;
using Blog;
using Blog.Screens.MenuPrincipal;
using Blog.Services;
using System.Text;
namespace Blog.Screens.PostScreens
{
    public static class SignInUser
    {

        public static User? Load()
        {

            Console.Clear();
            Console.WriteLine("Digite seu Email e senha");
            Console.WriteLine("-------------");

            Console.WriteLine("E-mail: ");
            string email = Console.ReadLine()!;

            Console.WriteLine("Senha: ");
            string password = MaskReadLine.ReadLineMasked();

            User? user = GetUser(email, password);
            if (user != null)
            {
                UserLogged.logged = user;
                Menu.Load();
            }
            else
            {
                Console.WriteLine("Email ou senha incorretos.");
                Console.ReadKey();
                MenuUser.Load();
            }

            return UserLogged.logged;

        }
        private static User GetUser(string? email, string? password)
        {
            var repository = new Repository<User>(DataConn.Connection!);

            var user = repository.Get().FirstOrDefault(x => x.Email == email);

            if (!EncDec.Decryp(password, user.PasswordHash))
                Console.WriteLine("Email ou senha incorretos");

            return user;

        }
    }
}