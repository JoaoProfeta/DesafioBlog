using System;
using Blog.Screens.MenuPrincipal;

namespace Blog.Screens.PostScreens
{
    public static class MenuPostScreen
    {
        public static void Load()
        {

            Console.Clear();
            var userLogg = UserLogged.logged;

            if (userLogg == null)
            {
                Console.WriteLine("Nenhum usuário está logado.");
                return;
            }

            Console.WriteLine("Gestão de Posts");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Post");
            Console.WriteLine("2 - Cadastrar Post");
            Console.WriteLine("3 - Atualizar Post");
            Console.WriteLine("4 - Excluir Post");
            Console.WriteLine($"{userLogg.Name} - {userLogg.Email} - {userLogg.Id}");

            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    ListPostsScreen.Load(userLogg);
                    break;
                case 2:
                    CreatePostScreen.Load(userLogg.Id, 7);
                    break;
                case 3:
                    UpdatePostScreen.Load();
                    break;
                case 4:
                    DeletePostScreen.Load();
                    break;
                case 5:
                    Menu.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}