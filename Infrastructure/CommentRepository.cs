using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class CommentRepository : AuditableRepository<Comment>, ICommentRepository
    {
        public CommentRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
        public Comment Get(int id)
        {
            return DbContext.Find<Comment>(id);
        }
        public void Remove(Comment entity)
        {
            DbContext.Remove(entity);
        }
    }
}