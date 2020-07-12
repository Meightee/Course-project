using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;

namespace Infrastructure
{
    public class PostRepository : AuditableRepository<Post>, IPostRepository
    {
        private readonly AppDbContext _dbContext;
        public PostRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public override Post Get(int id)
        {
            return _dbContext.Posts.Include(b => b.Board).FirstOrDefault(b => b.Id == id);
        }
        public void Remove(Post entity)
        {
            DbContext.Remove(entity);
        }
    }
}