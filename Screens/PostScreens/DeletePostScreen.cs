using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public static class DeletePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir um Post");
            Console.WriteLine("-------------");
            Console.Write("Qual o id do Post que deseja exluir?");
            var id = Console.ReadLine()!;
            Delete(int.Parse(id));
            Console.ReadKey();
            MenuPostScreen.Load();
        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Post>(DataConn.Connection!);
                repository.Delete(id);
                Console.WriteLine("Post Excluido com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível exluir o Post");
                Console.WriteLine(ex.Message);
            }
        }
    }
}