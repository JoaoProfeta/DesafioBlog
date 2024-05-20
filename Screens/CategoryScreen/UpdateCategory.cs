


using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreen
{
    public static class UpdateCategory
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Editar uma categoria: ");
            Console.WriteLine("--------------------- ");
            Console.WriteLine();
            ListCategories.Load(false);
            Console.WriteLine();
            Console.WriteLine("Digite o Id da Categoria: ");
            var idCategory = Console.ReadLine()!;
            Console.WriteLine("Novo nome:  ");
            var nome = Console.ReadLine()!;
            Console.WriteLine("Nova Slug:  ");
            var slug = Console.ReadLine()!;
            Update(int.Parse(idCategory), new Category
            {
                Name = nome,
                Slug = slug
            });
            MenuCategory.Load();
        }
        private static void Update(int id, Category newCategory)
        {
            try
            {
                var repository = new Repository<Category>(DataConn.Connection!);
                var pegandoPeloId = repository.Get(id);
                pegandoPeloId.Name = newCategory.Name;
                pegandoPeloId.Slug = newCategory.Name;
                repository.Update(pegandoPeloId);
                Console.Write("Sucesso ao editar categoria");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao criar categoria");
                Console.WriteLine(ex.Message);
            }

        }
    }
}