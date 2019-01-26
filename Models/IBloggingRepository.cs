using System;
using System.Linq;

namespace EFCoreNewDatabase.Models
{
    public interface IBloggingRepository
    {
        IQueryable<Blog> Blogs { get; }
        IQueryable<Post> Posts { get; }

        void AddBlog(Blog blog);
        void DeleteBlog(Blog blog);
        void AddPost(Post post);
        void DeletePost(Post post);
        // TODO: UpdateBlog
        // TODO: UpdatePost
    }
}
