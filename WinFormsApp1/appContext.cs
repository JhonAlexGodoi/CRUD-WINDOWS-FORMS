using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp1
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options)
       : base(options)
        { }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
    [Table("BLOG")]
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Name { get; set; }

        public virtual List<Post> Posts { get; set; }
    }

    [Table("POST")]
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Content { get; set; }

        [ForeignKey("BlogId")]
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
