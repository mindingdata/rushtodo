using JKang.EventSourcing.Domain;
using JKang.EventSourcing.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RushTodo.Data
{
    public class BaseRepository<T, TKey> : AggregateRepository<T, TKey> where T  : class, IAggregate<TKey>
    {
        public BaseRepository(IEventStore<T, TKey> eventStore) : base(eventStore)
        { }

        public Task Save(T item) => SaveAggregateAsync(item);

        public Task<T> GetById(TKey id) => FindAggregateAsync(id);

    }
}
