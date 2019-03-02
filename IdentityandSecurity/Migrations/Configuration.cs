namespace IdentityandSecurity.Migrations
{
    using IdentityandSecurity.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IdentityandSecurity.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "IdentityandSecurity.Models.ApplicationDbContext";
        }

        protected override void Seed(IdentityandSecurity.Models.ApplicationDbContext context)
        {
            //var hasher = new PasswordHasher();
            //context.Users.AddOrUpdate(u => u.UserName,
            //new ApplicationUser { UserName = "Jassar",PasswordHash=hasher.HashPassword("password") }
            //);
            if(!context.Users.Any(u=>u.Email== "jassar1994@gmail.com"))
            {
                var store = new  UserStore<ApplicationUser>(context);
                var manger = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { Email= "jassar1994@gmail.com" ,UserName= "jassar1994@gmail.com" };
                manger.Create(user, "password"); 
            }
        }
    }
}
