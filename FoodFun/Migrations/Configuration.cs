using System.Collections.Generic;
using FoodFun.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FoodFun.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FoodFun.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FoodFun.Models.ApplicationDbContext context)
        {
            if (!context.Roles.Any(r => r.Name == "admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "admin" };

                manager.Create(role);
            }

            if (!context.Users.Any(u => u.UserName == "boran@bekoo.co"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser
                {
                    UserName = "boran@bekoo.co",
                    Email = "boran@bekoo.co",
                    DisplayName = "Boran",
                    EmailConfirmed = true
                };

                manager.Create(user, "Password1.");
                manager.AddToRole(user.Id, "admin");

                #region Seed Categories and Products

                if (!context.Categories.Any())
                {
                    context.Categories.Add(new Category()
                    {
                        CategoryName = "Sample Category 1",
                        Products = new List<Product>()
                        {
                            new Product()
                            {
                                Title = "Sample Product 1",
                                AuthorId = user.Id,
                                Content = "<p>Nulla ornare sem sem, auctor posuere dolor semper a. Maecenas lorem sem, ultrices ut luctus in, mollis vehicula tellus. Sed laoreet volutpat urna eu porttitor. Fusce finibus, orci non finibus interdum, magna elit facilisis dui, sed elementum tortor nunc a magna. Fusce sed finibus justo, vel pulvinar nulla. Aenean magna est, porta et felis congue, scelerisque lacinia velit. Aenean a leo a leo posuere laoreet ut at sapien.</p>",
                                Slug = "sample-product-1",
                                CreationTime = DateTime.Now,
                                ModificationTime = DateTime.Now,
                                Price = 12.9
                            },

                            new Product()
                            {
                                Title = "Sample Product 2",
                                AuthorId = user.Id,
                                Content = "<p>In euismod ultrices finibus. Sed porta vestibulum consectetur. In non elit quis nulla maximus euismod sed nec lacus. Praesent id tellus a quam fermentum hendrerit. Fusce ultrices libero id tortor tincidunt condimentum. Pellentesque tristique nunc a quam mattis, vitae congue ex semper. In nec interdum sapien.</p>",
                                Slug = "sample-product-2",
                                CreationTime = DateTime.Now,
                                ModificationTime = DateTime.Now,
                                Price = 8.9
                            }
                        }
                    });
                }

                #endregion
            }
        }
    }
}
