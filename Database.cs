using Blog.Models;
using Microsoft.Data.SqlClient;

namespace Blog
{
    public static class DataConn
    {
        public static SqlConnection? Connection;
    }
    public static class UserLogged
    {
        public static User logged;

    }
}