using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
    public static class ListRolesScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Roles");
            Console.WriteLine("-------------");
            GetAll();
            Console.ReadKey();
            MenuRoleScreen.Load();
        }
        private static void GetAll()
        {
            var repository = new Repository<Role>(DataConn.Connection!);
            var role = repository.Get();
            foreach (var item in role)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Slug}");
            }
        }
    }
}