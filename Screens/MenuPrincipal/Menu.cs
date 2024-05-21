using Blog.Screens.CategoryScreen;
using Blog.Screens.PostScreens;
using Blog.Screens.RoleScreens;
using Blog.Screens.TagScreens;
using Blog.Screens.UserScreens;


namespace Blog.Screens.MenuPrincipal
{
    public static class Menu
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Meu Blog");
            Console.WriteLine("-----------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão de usuário");
            Console.WriteLine("2 - Gestão de Tags");
            Console.WriteLine("3 - Gestão de categoria");
            Console.WriteLine("4 - Gestão Posts");
            Console.WriteLine("5 - Sair da conta");
            Console.WriteLine("6 - Sair da aplicação ou");
            Console.WriteLine("7 - Relatórios");
            Console.WriteLine();
            Console.WriteLine(" Option: ");
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1: MenuUserScreen.Load(); break;
                case 2: MenuTagScreen.Load(); break;
                case 3: MenuCategory.Load(); break;
                case 4: MenuPostScreen.Load(); break;
                case 5: LogOut.Load(); break;
                case 6:
                    Console.Clear();
                    Environment.Exit(0);

                    break;
                default: Load(); break;
            }
        }
    }
}