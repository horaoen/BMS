using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;
using BMS.Models.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

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

            #endregion
        }
    }
}