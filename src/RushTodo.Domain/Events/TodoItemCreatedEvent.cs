using JKang.EventSourcing.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace RushTodo.Domain.Events
{
    public class TodoItemCreatedEvent : AggregateCreatedEvent<Guid>
    {
        public TodoItemCreatedEvent(Guid aggregateId, DateTime timestamp, string description, DateTime dueDate) 
            : base(aggregateId, timestamp)
        {
            Description = description;
            DueDate = dueDate;
        }

        public string Description { get; }

        public DateTime DueDate { get; }
    }
}
