using JKang.EventSourcing.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace RushTodo.Domain.Events
{
    public class TodoItemDeletedEvent : AggregateEvent<Guid>
    {
        public TodoItemDeletedEvent(Guid aggregateId, int aggregateVersion, DateTime timestamp)
       : base(aggregateId, aggregateVersion, timestamp)
        {
        }
    }
}
