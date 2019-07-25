using JKang.EventSourcing.Persistence;
using RushTodo.Domain.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;

namespace RushTodo.Data
{
    public class TodoItemRepository : BaseRepository<TodoItem, Guid>, ITodoItemRepository
    {
        public TodoItemRepository(IEventStore<TodoItem, Guid> eventStore) : base(eventStore)
        { }


    }
}
