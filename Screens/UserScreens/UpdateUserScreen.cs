using System;
using Blog.Models;
using Blog.Repositories;
using Microsoft.IdentityModel.Tokens;

namespace Blog.Screens.TagScreens
{
    public static class UpdateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando uma tag");
            Console.WriteLine("-------------");
            Console.Write("Id: ");
            var id = Console.ReadLine();

            Console.Write("Nome: ");
            var name = Console.ReadLine()!;
            Console.Write("E-mail: ");
            var email = Console.ReadLine()!;
            Console.Write("Bio: ");
            var bio = Console.ReadLine()!;
            Console.Write("url da imagem: ");
            var imageUrl = Console.ReadLine()!;
            Console.Write("Slug: ");
            var slug = Console.ReadLine()!;

            Update(new User
            {
                Id = int.Parse(id!),
                Name = name,
                Email = email,
                Bio = bio,
                Image = imageUrl,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Update(User user)
        {
            try
            {
                var repository = new Repository<User>(DataConn.Connection!);
                repository.Update(user);
                Console.WriteLine("Tag atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}