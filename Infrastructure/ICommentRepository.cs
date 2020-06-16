using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Infrastructure.CRUDInterfaces;

namespace Infrastructure
{
    public interface ICommentRepository : ICanAdd<Comment>, ICanDelete<Comment>, ICanGet<Comment>, ICanUpdate<Comment>
    {
    }
}
