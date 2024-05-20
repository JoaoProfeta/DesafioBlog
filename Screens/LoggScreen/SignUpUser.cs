using System;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.UserScreens;
namespace Blog.Screens.PostScreens
{
    public static class SignUpUser
    {
        public static void Load()
        {
            CreateUserScreen.Load();
            Console.WriteLine("User Criado com sucesso, aperte Enter para fazer o login!!");
            MenuUser.Load();
            Console.ReadKey();
        }
        
    }
}