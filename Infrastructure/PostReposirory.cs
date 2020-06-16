using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class PostRepository : AuditableRepository<Post>, IPostRepository
    {
        public PostRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
        public Post Get(int id)
        {
            return DbContext.Find<Post>(id);
        }
        public void Remove(Post entity)
        {
            DbContext.Remove(entity);
        }
    }
}