using Microsoft.EntityFrameworkCore;
using NewsPress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPress.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Theme> Themes { get; set; }
    }
}
