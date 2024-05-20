using Blog.Models;
using Blog.Repositories;
using Blog.Screens.UserScreens;

namespace Blog.Screens.UsersScreens
{
    public static class ListUsersScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de usuários");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<User>(DataConn.Connection!);
            var users = repository.Get().ToList();
            foreach (var item in users)
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Email})");
        }
    }
}