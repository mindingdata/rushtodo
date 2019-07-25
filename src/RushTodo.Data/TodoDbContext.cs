using JKang.EventSourcing.Persistence.EfCore;
using Microsoft.EntityFrameworkCore;
using RushTodo.Domain.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;

namespace RushTodo.Data
{
    public class TodoItemDbContext : DbContext, IEventSourcingDbContext<TodoItem, Guid>
    {
        public TodoItemDbContext(DbContextOptions<TodoItemDbContext> options) : base(options)
        {
        }

        public DbSet<EventEntity<Guid>> TodoItemEvents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => modelBuilder.ApplyConfiguration(new EventEntityConfiguration<Guid>());

        public DbSet<EventEntity<Guid>> GetDbSet()
        {
            return TodoItemEvents;
        }
    }
}
