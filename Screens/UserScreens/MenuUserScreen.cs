using System;
using Blog.Screens.TagScreens;
using Blog.Screens.UsersScreens;
using Blog.Screens.MenuPrincipal;
namespace Blog.Screens.UserScreens
{
    public static class MenuUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Users");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Users");
            Console.WriteLine("2 - Pegar um User");
            Console.WriteLine("3 - Cadastrar User");
            Console.WriteLine("4 - Atualizar User");
            Console.WriteLine("5 - Excluir User");
            Console.WriteLine("6 - Voltar ao menu Principal");
            Console.WriteLine();
            short option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    ListUsersScreen.Load();
                    break;
                case 2:
                    GetUserScreen.Load();
                    break;
                case 3:
                    CreateUserScreen.Load();
                    break;
                case 4:
                    UpdateUserScreen.Load();
                    break;
                case 5:
                    DeleteUserScreen.Load();
                    break;
                case 6:
                    Menu.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}