using System;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.MenuPrincipal;
namespace Blog.Screens.PostScreens
{
    public static class MenuUser
    {
        public static void Load()
        {
            
            Console.Clear();
            Console.WriteLine("Bem vindo ao nosso App de Console !!!");
            Console.WriteLine("-------------");
            Console.WriteLine(" 1 - Entrar em um Usuário ");
            Console.WriteLine(" 2 - Criar um Usuário");
            Console.WriteLine(" 3 - Continuar sem usuário ");
            var optionsUser = Console.ReadLine();
            switch (short.Parse(optionsUser!))
            {
                case 1:
                    SignInUser.Load(); break;
                case 2:
                    SignUpUser.Load();
                    break;
                case 3:
                    Menu.Load();
                    break;
                default: Load(); break;

            }

        }

    }
}