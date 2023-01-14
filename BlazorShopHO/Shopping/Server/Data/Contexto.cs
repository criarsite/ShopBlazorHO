using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 

namespace Server.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<Product>().HasData(
            new  Product { Id=1, Title="dotNet", Description=".NET is a free and open source framework for Windows, Linux and macOS operating systems. It is an open source successor to the .NET Framework. The project is primarily developed by Microsoft and released under the MIT License.", ImageUrl="https://dotnet.microsoft.com/blob-assets/images/e-books/blazor-for-web-forms-devs.png", Price=100},
            new  Product { Id=2, Title="C#", Description="C# is a strongly typed, multiparadigm programming language developed by Microsoft as part of the .NET platform. Its object-oriented syntax was based on C++ but includes many influences from other programming languages, such as Object Pascal and, mainly, Java.", ImageUrl="https://cdn.syncfusion.com/content/images/downloads/ebook/ebook-cover/C-sharp-Succinctly-Updated-1.png", Price=100},
            new  Product { Id=3, Title="Blazor", Description="Blazor is a free and open source web framework that allows developers to build web apps using C# and HTML. It is being developed by Microsoft.", ImageUrl="https://cdn.syncfusion.com/content/images/downloads/ebook/ebook-cover/blazor-succinctly.png", Price=100}

             );
        }

        public DbSet<Product> Products {get; set;}
    }
}