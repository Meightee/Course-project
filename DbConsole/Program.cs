using Entities;
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
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Forrrum;Trusted_Connection=True;",
                b => b.MigrationsAssembly("Infrastructure"));
            return new AppDbContext(optionsBuilder.Options);
        }
    }
    class Program
    {
        private static readonly AppDbContext _appContext;
        private static IBoardRepository _boardRepository;
        private static IPostRepository _postRepository;
        private static ICommentRepository _commentRepository;
        static Program()
        {
            AppDbContextFactory factory = new AppDbContextFactory();
            _appContext = factory.CreateDbContext(null);
            _boardRepository = new BoardRepository(_appContext);
            _postRepository = new PostRepository(_appContext);
            _commentRepository = new CommentRepository(_appContext);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Start!");

            Board board = new Board("Хватит ");
            _boardRepository.Add(board);
            Post post = new Post(board.Id, "хватит", "хватит");
            _postRepository.Add(post);
            Comment comment = new Comment(post.Id, "хватит");
            _commentRepository.Add(comment);
        }
    }
}
