using RushTodo.Domain.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;

namespace RushTodo.Data
{
    public interface ITodoItemRepository : IRepository<TodoItem, Guid>
    {

    }
}
