using JKang.EventSourcing.Domain;
using JKang.EventSourcing.Events;
using RushTodo.Domain.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace RushTodo.Domain.Aggregates
{
    public class TodoItem : Aggregate<Guid>
    {
        public TodoItem(string description, DateTime dueDate) 
            : base(new TodoItemCreatedEvent(Guid.NewGuid(), DateTime.UtcNow, description, dueDate))
        {

        }

        public TodoItem(Guid id, IEnumerable<IAggregateEvent<Guid>> savedEvents)
            : base(id, savedEvents)
        {

        }

        public DateTime DateCreated { get; private set; }

        public string Description { get; private set; }

        public DateTime DueDate { get; private set; }

        public DateTime? DateDeleted { get; private set; }

        public void UpdateDetails(string description, DateTime dueDate) => ReceiveEvent(new TodoItemUpdatedEvent(Id, GetNextVersion(), DateTime.UtcNow, description, dueDate));

        public void Delete() => ReceiveEvent(new TodoItemDeletedEvent(Id, GetNextVersion(), DateTime.UtcNow));


        protected override void ApplyEvent(IAggregateEvent<Guid> @event)
        {
            if(@event is TodoItemCreatedEvent createdEvent)
            {
                DateCreated = createdEvent.Timestamp;
                Description = createdEvent.Description;
                DueDate = createdEvent.DueDate;
            }

            if(@event is TodoItemUpdatedEvent updatedEvent)
            {
                Description = updatedEvent.Description;
                DueDate = updatedEvent.DueDate;
            }

            if(@event is TodoItemUpdatedEvent deleteEvent)
            {
                DateDeleted = deleteEvent.Timestamp;
            }
        }
    }
}
