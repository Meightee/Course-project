using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;

namespace Infrastructure
{
    public class BoardRepository : AuditableRepository<Board>, IBoardRepository
    {
        private readonly AppDbContext _dbContext;
        public BoardRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public IReadOnlyList<Board> GetAll()
        {
            return _dbContext.Boards.ToList();
        }
    }
}