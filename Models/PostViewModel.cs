using System;
using System.Collections.Generic;

namespace EFCoreNewDatabase.Models
{
    public class PostViewModel
    {
        public Blog blog { get; set; }
        public IEnumerable<Post> Posts { get; set; }
    }
}
