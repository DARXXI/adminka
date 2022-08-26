using AdminPanel.Repository;
using AdminPanel.Domain.Entities;
using System.Numerics;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        using var context = new DataBaseContext();
        //?????
        {
            Role r1 = new Role { Name = "Administrator" };
            Role r2 = new Role { Name = "Operator" };
            Role r3 = new Role { Name = "Editer" };
            context.Roles.Add(r1);
            context.Roles.Add(r2);
            context.Roles.Add(r3);
            context.SaveChanges();
            User u1 = new User { Id = 7, Name = "Tom", Email = "tom@gmail.com", Password = "12345", Phone = "89162600496", RoleId = 1, City="Moscow" };
            User u2 = new User { Id = 2, Name = "Peter", Email = "peter@gmail.com", Password = "12345", Phone = "79162600496", /*Role = context.Roles.ToArray()[1],*/ City = "Moscow" };
            User u3 = new User { Id = 3, Name = "Derek", Email = "derek@gmail.com", Password = "12345", Phone = "69162600496", /*Role = context.Roles.ToArray()[2],*/ City = "Moscow" };
            context.Users.AddRange(new List<User> { u1, u2, u3 });
            context.SaveChanges();

            context.Roles.Where(T => T.Name == "Administrator");
            context.Roles.First(T => T.Name == "Administrator");
        }
            //{

            //    var std = new Role()
            //    {
            //        Name = "admin"
            //    };

            //    context.Roles.Add(std);
            //    context.SaveChanges();
            //}
        }
}