using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace DbConsole
{
    //Фабрика для создания объекта контекста базы данных во время разработки
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Forrrum;Trusted_Connection=True;", b => b.MigrationsAssembly("Infrastructure"));
            return new AppDbContext(optionsBuilder.Options);
        }
    }

    class Program
    {
        private static readonly AppDbContext _appContext;
        // private static IBookRepository _bookRepository;
        //private static IAuthorRepository _authorRepository;
        static Program()
        {
            AppDbContextFactory factory = new AppDbContextFactory();
            _appContext = factory.CreateDbContext(null);
            // _authorRepository = new AuthorRepository(_appContext);
            //_bookRepository = new BookRepository(_appContext);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Start!");

            //Author author = new Author("Александр", "Пушкин", "Сергеевич");
            //authorRepository.Add(author);
            //Book book = new Book(author.Id, "Сборник стихов", "Сборник стихов", 250);
            //_bookRepository.Add(book);
        }
    }
}
