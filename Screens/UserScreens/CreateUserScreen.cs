using Blog.Models;
using Blog.Repositories;
using Blog.Services;

namespace Blog.Screens.UserScreens
{
    public static class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo Usuário");
            Console.WriteLine("-------------");
            Console.Write("Nome: ");
            var name = Console.ReadLine()!;
            Console.Write("E-mail: ");
            var email = Console.ReadLine()!;
            Console.Write("Senha: ");
            var passwordHash = Console.ReadLine()!;
            Console.Write("Biografia: ");
            var bio = Console.ReadLine()!;
            Console.Write("Url da imagem: ");
            var imageUrl = Console.ReadLine()!;
            Console.Write("Slug: ");
            var slug = Console.ReadLine()!;
           
            
            Create(new User
            {
                Name = name,
                Email = email,
                PasswordHash = EncDec.Cryp(passwordHash),
                Bio = bio,
                Image = imageUrl,
                Slug = slug,
            });
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Create(User user)
        {
            try
            {
                var repository = new Repository<User>(DataConn.Connection!);
                repository.Create(user);
                Console.WriteLine("User Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar o User");
                Console.WriteLine(ex.Message);
            }
        }
    }
}