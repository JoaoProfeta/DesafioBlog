using System;
using Blog.Screens.TagScreens;
using Blog.Screens.UsersScreens;
using Blog.Screens.MenuPrincipal;
using Blog.Screens.PostScreens;
namespace Blog.Screens.UserScreens
{
    public static class MenuUserScreen
    {
        public static void Load()
        {
            var user = UserLogged.logged;
            if (user == null)
            {
                Console.Clear();
                Console.WriteLine("Gestão de Users");
                Console.WriteLine("--------------");
                Console.WriteLine("1 - Cadastrar User");
                Console.WriteLine("2 - Logar User");
                Console.WriteLine("3 - Voltar ao menu Principal");
                short option = short.Parse(Console.ReadLine()!);

                switch (option)
                {
                    case 1:
                        SignUpUser.Load();
                        break;
                    case 2:
                        SignInUser.Load();
                        break;
                    case 3:
                        Menu.Load();
                        break;
                    default: Load(); break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Gestão de Users");
                Console.WriteLine("--------------");
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine();
                Console.WriteLine("1 - Perfil do User");
                Console.WriteLine("3 - Atualizar dados");
                Console.WriteLine("4 - Excluir User");
                Console.WriteLine("5 - Voltar ao menu Principal");
                Console.WriteLine();
                short option = short.Parse(Console.ReadLine()!);

                switch (option)
                {
                    case 1:
                        GetUserScreen.Load();
                        break;
                    case 2:
                        UpdateUserScreen.Load();
                        break;
                    case 3:
                        DeleteUserScreen.Load();
                        break;
                    case 4:
                        Menu.Load();
                        break;
                    default: Load(); break;
                }
            }

        }
    }
}