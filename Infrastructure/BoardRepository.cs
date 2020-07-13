using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class BoardRepository : AuditableRepository<Board>, IBoardRepository
    {
        private readonly AppDbContext _dbContext;
        public BoardRepository(AppDbContext dbContext) : base(dbContext)
        {
             _dbContext = dbContext;
        }
        public Board Get(int id)
        {
            return DbContext.Find<Board>(id);
        }
        public void Remove(Board entity)
        {
            DbContext.Remove(entity);
        }
    }
}