


using Blog.Screens.MenuPrincipal;

namespace Blog.Screens.CategoryScreen
{
    public static class MenuCategory
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao menu de categorias!!");
            Console.WriteLine();
            Console.WriteLine("O que você deseja fazer? ");
            Console.WriteLine();
            Console.WriteLine(" 1 - Listar categorias");
            Console.WriteLine(" 2 - Criar uma categoria");
            Console.WriteLine(" 3 - Editar uma categoria");
            Console.WriteLine(" 4 - Apagar uma categoria");
            Console.WriteLine(" 5 - Voltar para o menu principal");
            Console.WriteLine("--------------------------");
            var select = Console.ReadLine()!;

            switch (short.Parse(select))
            {
                case 1: ListCategories.Load(true); break;
                case 2: CreateCategory.Load(); break;
                case 3: UpdateCategory.Load(); break;
                case 4: DeleteCategory.Load(); break;
                case 5: Menu.Load(); break;
            }



        }
    }
}