using System;
using Blog.Models;
using Blog.Repositories;


namespace Blog.Screens.CategoryScreen
{
    public static class ListCategories
    {
        public static void Load(bool thisRead)
        {

            if (thisRead == true)
                Console.Clear();

            Console.WriteLine("Todas as categorias: ");
            GetAll();
            if (thisRead == true)
            {
                Console.ReadKey();
                MenuCategory.Load();
            }

        }

        private static void GetAll()
        {
            try
            {
                var repository = new Repository<Category>(DataConn.Connection!);
                var listCategory = repository.Get().ToList();
                foreach (var item in listCategory)
                {
                    Console.WriteLine($"ID:{item.Id} - Name:{item.Name} - Slug:{item.Slug}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao listar categorias");
                Console.WriteLine(ex.Message);
            }

        }
    }
}