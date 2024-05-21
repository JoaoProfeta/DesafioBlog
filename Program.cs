using Blog.Screens.MenuPrincipal;
using Blog.Screens.PostScreens;
using Blog.Screens.RoleScreens;
using Blog.Screens.TagScreens;
using Blog.Screens.UserScreens;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True;";

        static void Main(string[] args)
        {
            DataConn.Connection = new SqlConnection(CONNECTION_STRING);
            DataConn.Connection.Open();
            // Console.BackgroundColor = ConsoleColor.DarkBlue;
            // Console.SetWindowSize(50, 30);
            // Console.WindowHeight(50);

            MenuUser.Load();
            Console.ReadKey();
            DataConn.Connection.Close();
        }


    }
}
