using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Infrastructure.CRUDInterfaces;

namespace Infrastructure
{
    public interface IBoardRepository : ICanAdd<Board>, ICanDelete<Board>, ICanGet<Board>, ICanUpdate<Board>
    {
    }
}
