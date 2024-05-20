using System;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.PostScreens;

namespace Blog.Screens.UserScreens
{
    public static class DeleteUserScreen
    {
        public static void Load()
        {
            var user = UserLogged.logged;
            Console.Clear();
            Console.WriteLine("Excluir um usuário");
            Console.WriteLine("-------------");
            Console.Write("Tem certeza que deseja excluir o usuário? ");
            Console.Write(" 1 - Sim ");
            Console.Write(" 2 - Não, voltar para o menu ");

            var option = int.Parse(Console.ReadLine());
            if (option != 1 && option != 2)
            {
                Console.WriteLine("opção incorreta, Digite novamente ");
                return;
            }
            else if (option == 1)
            {
                Delete(user.Id);
            }
            else
            {
                MenuUserScreen.Load();
            }
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