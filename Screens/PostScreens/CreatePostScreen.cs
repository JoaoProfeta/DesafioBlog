using System.Text;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.CategoryScreen;

namespace Blog.Screens.PostScreens
{
    public static class CreatePostScreen
    {
        public static void Load(int authorId, int categoryId)
        {
            Console.Clear();
            Console.WriteLine("Novo Post");
            Console.WriteLine("-------------");
            Console.Write("Titulo: ");
            var title = Console.ReadLine();
            Console.Write("Categoria do post: ");
            ListCategories.Load(false);
            Console.WriteLine();
            Console.WriteLine("Digite apenas o ID");
            var category = Console.ReadLine()!;
            Console.WriteLine("fale os detalhes de sua aplicação: ");
            Console.WriteLine("para sair da edição aperte ENTER, e na linha vazia aperte ESC");
            var body = new StringBuilder();
            do
            {
                body.Append(Console.ReadLine());
                body.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("Resumo: ");
            var summary = new StringBuilder();
            do
            {
                summary.Append(Console.ReadLine());
                summary.Append(Environment.NewLine);

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Post
            {
                Title = title,
                AuthorId = authorId,
                CategoryId = int.Parse(category),
                Body = body.ToString(),
                Summary = summary.ToString(),
                slug = slug,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now

            });
            Console.ReadKey();
            MenuPostScreen.Load();
        }
        public static void Create(Post post)
        {
            try
            {
                var repository = new Repository<Post>(DataConn.Connection!);
                repository.Create(post);
                Console.WriteLine("Post adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar o Post");
                Console.WriteLine(ex.Message);
            }
        }
    }
}