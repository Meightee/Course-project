using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CRUDInterfaces
{
    public interface ICanGet<TEntity> where TEntity : class
    {
        TEntity Get(int id);
    }
}
