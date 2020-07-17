using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;

namespace Infrastructure
{
    public class CommentRepository : AuditableRepository<Comment>, ICommentRepository
    {
        private readonly AppDbContext _dbContext;
        public CommentRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public override Comment Get(int id)
        {
            return _dbContext.Comments.Include(b => b.Post).FirstOrDefault(b => b.Id == id);
        }
        public IReadOnlyList<Comment> GetAll()
        {
            return _dbContext.Comments.Include(b => b.Post).ToList();
        }
    }
}