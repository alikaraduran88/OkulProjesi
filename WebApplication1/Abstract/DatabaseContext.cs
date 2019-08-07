using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Abstract
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
            // Server=myServerAddress;Database=myDataBase;User Id=myUsername;            Password = myPassword;
            Database.Connection.ConnectionString = "server=.;database=PROJE;uid=sa;pwd=123";
        }

        public DbSet<AlinanDersler> AlinanDersler { get; set; }
        public DbSet<Duyuru> Duyuru { get; set; }
        public DbSet<Lesson> Lesson { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Yoklama> Yoklama { get; set; }
    }
}