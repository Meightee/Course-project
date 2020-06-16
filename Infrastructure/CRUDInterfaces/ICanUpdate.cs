using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CRUDInterfaces
{
    public interface ICanUpdate <TEntity> where TEntity : class
    {
        void Update(TEntity entity);
    }
}
