using System;
using Repository.Core;
using Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Repository
{
    class Program
    {
        static public IConfigurationRoot Configuration { get; set; }
        static void Main(string[] args)
        {
             var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            //  var optionsBuilder = new DbContextOptionsBuilder();
            //  optionsBuilder.Options.UseSqlServer(optionsBuilder, Configuration.GetConnectionString("DefaultConnection"));
            var context = new DbContextBase<TestEntity>(Configuration.GetConnectionString("DefaultConnection"));
            var service = new TestService(new UnitOfWork(context));
            var entity = new TestEntity();
            entity.DateCreated=DateTime.Now;
            entity.DateUpdated=DateTime.Now;
            entity.Guid = Guid.NewGuid();
            entity.Name="Bhushan";
            entity.Version=1;
            service.Add(entity);
            Console.WriteLine("Hello World!");
        }
    }
}
