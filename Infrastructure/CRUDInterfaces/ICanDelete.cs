using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CRUDInterfaces
{
    public interface ICanDelete<TEntity> where TEntity : class
    {
        void Remove(TEntity entity);
    }
}
