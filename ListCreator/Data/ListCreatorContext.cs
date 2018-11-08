using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ListCreator.Models
{
    public class ListCreatorContext : DbContext
    {
        public ListCreatorContext (DbContextOptions<ListCreatorContext> options)
            : base(options)
        {
        }

        public DbSet<ListCreator.Models.List> List { get; set; }
    }
}
