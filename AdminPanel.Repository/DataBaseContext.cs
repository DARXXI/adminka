using System.Reflection;
using AdminPanel.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Repository
{
    public class DataBaseContext : DbContext
    {
        //private readonly string _conectionString;
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=admin");
        }

        //public DataBaseContext(string conectionString)
        //{
        //    _conectionString = conectionString;
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //выдает ошибку при запуски WebClient части
        //Assembly.расшарить
        //}


        //        new User { Id=1, Name="Tom", Email="tom@gmail.com", Password="12345", Phone="89162600496", Role=Roles.ToArray()[0]},
        //        new User { Id=2, Name="Peter", Email="peter@gmail.com", Password="12345", Phone="79162600496", Role=Roles.ToArray()[1]},
        //        new User { Id=3, Name="Derek", Email="derek@gmail.com", Password="12345", Phone="69162600496", Role=Roles.ToArray()[2]},

        //OnModelCreating -> атрибуты почитать
    }
    }
