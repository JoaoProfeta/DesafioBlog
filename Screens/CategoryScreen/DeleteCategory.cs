


using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreen
{
    public static class DeleteCategory
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deletar categoria");
            Console.WriteLine("------------------");
            Console.WriteLine();
            ListCategories.Load(false);
            Console.WriteLine();
            Console.WriteLine("Digite o Id da categoria que você quer deletar");
            var idCategoria = Console.ReadLine()!;
            Delete(int.Parse(idCategoria));
            Console.ReadKey();
            MenuCategory.Load();
        }
        private static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Category>(DataConn.Connection!);
                repository.Delete(id);
                Console.WriteLine("Sucesso ao deletar a categoria");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro ao deletar categoria");
                Console.WriteLine(ex.Message);


            }
        }
    }
}