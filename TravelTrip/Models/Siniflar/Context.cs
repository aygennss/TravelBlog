using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelTrip.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<Afmin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<İletisim > iletisims { get; set; }
        public DbSet<Yorumlar > Yorumlars { get; set; }

    }
}