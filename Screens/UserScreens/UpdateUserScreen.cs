using System;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.MenuPrincipal;
using Microsoft.IdentityModel.Tokens;

namespace Blog.Screens.TagScreens
{
    public static class UpdateUserScreen
    {
        public static void Load()
        {
            var user = UserLogged.logged;
            Console.Clear();
            Console.WriteLine("Atualizando o Usuário");
            Console.WriteLine("-------------");
            Console.Write($"Nome: '{user.Name}' Para :");
            var name = Console.ReadLine();
            Console.Write($"E-mail: '{user.Email}' Para :");
            var email = Console.ReadLine();
            Console.Write($"Bio: '{user.Bio}' Para :");
            var bio = Console.ReadLine();
            Console.Write($"url: '{user.Image}' Para :");
            var imageUrl = Console.ReadLine();
            Console.Write($"Slug: '{user.Slug}' Para :");
            var slug = Console.ReadLine();

            Update(new User
            {
                Id = user.Id,
                Name = !string.IsNullOrWhiteSpace(name) ? name : user.Name,
                Email = !string.IsNullOrWhiteSpace(email) ? email : user.Email,
                Bio = !string.IsNullOrWhiteSpace(bio) ? bio : user.Bio,
                Image = !string.IsNullOrWhiteSpace(imageUrl) ? imageUrl : user.Image,
                Slug = !string.IsNullOrWhiteSpace(slug) ? slug : user.Slug,
                PasswordHash = user.PasswordHash
            });
            Console.ReadKey();
            Menu.Load();
        }

        public static void Update(User user)
        {
            try
            {
                var repository = new Repository<User>(DataConn.Connection!);
                repository.Update(user);
                UserLogged.logged = user;
                Console.WriteLine("User atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar o User");
                Console.WriteLine(ex.Message);
            }
        }
    }
}