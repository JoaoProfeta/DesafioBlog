
using Blog.Models;
using Blog.Screens.MenuPrincipal;
namespace Blog.Screens.PostScreens
{
    public static class LogOut
    {
        public static void Load()
        {
            UserLogged.logged = UserLoggedOut.loggedOut;
            MenuUser.Load();
        }

    }
}