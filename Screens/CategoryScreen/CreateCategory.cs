


using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreen
{
    public static class CreateCategory
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Criar categoria: ");
            Console.WriteLine("------------------");
            Console.WriteLine("Nome: ");
            var name = Console.ReadLine();
            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Create(new Category
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuCategory.Load();
        }
        private static void Create(Category category)
        {
            try
            {
                var repository = new Repository<Category>(DataConn.Connection!);
                repository.Create(category);
                Console.WriteLine("Categoria Criada com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao criar categoria");
                Console.WriteLine(ex.Message);

            }
        }
    }
}