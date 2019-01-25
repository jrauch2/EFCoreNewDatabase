using System;
using System.Linq;

namespace EFCoreNewDatabase.Models
{
    public interface IBloggingRepository
    {
        IQueryable<Blog> Blogs { get; }
        IQueryable<Post> Posts { get; }

        // TODO: AddBlog, UpdateBlog, DeleteBlog
        // TODO: AddPost, UpdatePost, DeletePost
    }
}
