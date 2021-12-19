using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text.Json;
using BMS.Controllers;
using BMS.Models.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Validations;

namespace BMS.Database
{
    public static class SeedData
    {
        public static IApplicationBuilder UseDataInitializer(this IApplicationBuilder builder)
        {
            using var scope = builder.ApplicationServices.CreateScope();
            var dbContext = scope.ServiceProvider.GetService<AppDbContext>();
            System.Console.WriteLine("=====开始执行迁移数据库======");
            if (dbContext != null) dbContext.Database.Migrate();
            else System.Console.WriteLine("ERROR: 请注入数据库上下文对象!!!");
            System.Console.WriteLine("=====数据库迁移完成=====");
            return builder;
        }

        public static void SetInitialData(this ModelBuilder modelBuilder)
        {
            #region 添加书目种子数据
            var bookTitleData = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) +
                                                 @"/Database/MockData/bookTitles.json");
            IList<BookTitle>? bookTitles =
                JsonSerializer.Deserialize<IList<BookTitle>>(
                    bookTitleData, 
                    new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }) 
                ?? new List<BookTitle>();

            var bookItems = new List<BookTitleItem>();
            foreach (var bookTitle in bookTitles)
            {
                for (int i = 0; i < bookTitle.TotalNumber; i++)
                {
                    bookItems.Add(new BookTitleItem() 
                    { 
                        Id = Guid.NewGuid(), 
                        BookTitleId = bookTitle.Id, 
                        IsBorrowed = false
                    });
                }
            }
            
            modelBuilder.Entity<BookTitle>().HasData(bookTitles);
            modelBuilder.Entity<BookTitleItem>().HasData(bookItems);
            
            #endregion

            #region 添加用户种子数据

            var superAdmin = new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "SuperAdmin",
                NormalizedName = "SuperAdmin".ToUpper()
            };
            var admin = new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Admin",
                NormalizedName = "Admin".ToUpper()
            };
            var borrower = new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Borrower",
                NormalizedName = "Borrower".ToUpper()
            };
            //角色集合
            var roles = new List<IdentityRole>()
            {
                superAdmin,
                admin,
                borrower
            };

            var superAdminUser = new User()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "horaoen",
                NormalizedUserName = "horaoen".ToUpper(),
                Email = "horaoen@gmail.com",
                NormalizedEmail = "horaoen@gmail.com".ToUpper(),
                PhoneNumber = "15137667148",
                Fine = 0
            };
            var adminUser = new User()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "bleso",
                NormalizedUserName = "bleso".ToUpper(),
                Email = "bleso624@gmail.com",
                NormalizedEmail = "bleso624@gmail.com".ToUpper(),
                PhoneNumber = "15137667148",
                Fine = 0
            };
            var borrowerUser = new User()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "fhr",
                NormalizedUserName = "fhr".ToUpper(),
                Email = "2495644988@qq.com",
                NormalizedEmail = "2495644988@qq.com",
                PhoneNumber = "15137667148",
                Fine = 0
            };

            //设置用户密码
            superAdminUser.PasswordHash = new PasswordHasher<User>()
                .HashPassword(superAdminUser, "Horaoen@624");
            adminUser.PasswordHash = new PasswordHasher<User>()
                .HashPassword(adminUser, "Horaoen@624");
            borrowerUser.PasswordHash = new PasswordHasher<User>()
                .HashPassword(borrowerUser, "Horaoen@624");
            
            //用户集合
            var users = new List<User>()
            {
                superAdminUser,
                adminUser,
                borrowerUser
            };

            var superAdminUserRole = new IdentityUserRole<string>()
            {
                UserId = superAdminUser.Id,
                RoleId = superAdmin.Id,
            };
            var adminUserRole = new IdentityUserRole<string>()
            {
                UserId = adminUser.Id,
                RoleId = admin.Id,
            };
            var borrowerUserRole = new IdentityUserRole<string>()
            {
                UserId = borrowerUser.Id,
                RoleId = borrower.Id,
            };
            
            //用户角色集合
            var userRoles = new List<IdentityUserRole<string>>()
            {
                superAdminUserRole,
                adminUserRole,
                borrowerUserRole
            };

            //注入数据
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<IdentityRole>().HasData(roles);
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
            #endregion
        }
    }
}