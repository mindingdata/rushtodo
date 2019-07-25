using JKang.EventSourcing.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace RushTodo.Domain.Events
{
    public class TodoItemUpdatedEvent : AggregateEvent<Guid>
    {
        public TodoItemUpdatedEvent(Guid aggregateId, int aggregateVersion, DateTime timestamp, string description, DateTime dueDate) 
        : base(aggregateId, aggregateVersion, timestamp)
        {
            Description = description;
            DueDate = dueDate;
        }

        public string Description { get;  }

        public DateTime DueDate { get; }
    }
}
