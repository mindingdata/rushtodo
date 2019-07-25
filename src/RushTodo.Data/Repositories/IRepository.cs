using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RushTodo.Data
{
    public interface IRepository<T, TKey>
    {
        Task Save(T item);

        Task<T> GetById(TKey id);
    }
}
