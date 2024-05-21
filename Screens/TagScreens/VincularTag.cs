using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class VincularTag
    {
        public static void VincularPostTag(int postId, int tagId)
        {
            var repositoryVincular = new Repository<PostTag>(DataConn.Connection!);
            var vincular = new PostTag { PostId = postId, TagId = tagId };
            repositoryVincular.Create(vincular);
        }
    }
}