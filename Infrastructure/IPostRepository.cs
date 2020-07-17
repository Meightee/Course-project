using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Infrastructure.CRUDInterfaces;

namespace Infrastructure
{
    public interface IPostRepository : ICanAdd<Post>, ICanGet<Post>
    {
        IReadOnlyList<Post> GetAll();
    }
}
