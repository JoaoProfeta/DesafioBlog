using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class DeleteUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir um usuário");
            Console.WriteLine("-------------");
            Console.Write("Qual o id do usuário que deseja exluir? ");
            var id = Console.ReadLine();
            Delete(int.Parse(id!));
            Console.ReadKey();
            MenuUserScreen.Load();
        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<User>(DataConn.Connection!);
                repository.Delete(id);
                Console.WriteLine("User excluído com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível exluir a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}