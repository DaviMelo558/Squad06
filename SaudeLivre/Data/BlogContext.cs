using Microsoft.EntityFrameworkCore;
using SaudeLivre.Models;

namespace SaudeLivre.Data{
    public class BlogContext:DbContext
    {
          public BlogContext(DbContextOptions<BlogContext> opt): base(opt)
        {
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

    }
}