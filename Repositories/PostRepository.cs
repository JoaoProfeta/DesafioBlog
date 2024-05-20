using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class PostRepository : Repository<Post>
    {
        private readonly SqlConnection _connection;

        public PostRepository(SqlConnection connection) : base(connection)
        {
            _connection = connection;
        }
        public List<Post> GetPostsByAuthorId(int authorId)
        {
            var query = @"
                SELECT * FROM [Post]
                WHERE [AuthorId] = @AuthorId";

            return _connection.Query<Post>(query, new { AuthorId = authorId }).ToList();

        }

    }
}