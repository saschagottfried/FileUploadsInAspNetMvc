using FileUploadsInAspNetMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FileUploadsInAspNetMvc.DAL
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Image> Images { get; set; }
    }
}