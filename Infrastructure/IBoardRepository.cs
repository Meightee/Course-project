using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Infrastructure.CRUDInterfaces;

namespace Infrastructure
{
    public interface IBoardRepository : ICanAdd<Board>, ICanGet<Board>
    {
        IReadOnlyList<Board> GetAll();
    }
}
