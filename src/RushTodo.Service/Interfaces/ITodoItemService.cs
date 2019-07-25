using RushTodo.Domain.Aggregates;
using RushTodo.Service.Models.TodoItem;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RushTodo.Service.Interfaces
{
    public interface ITodoItemService
    {
        Task<GetModel> Create(CreateModel createModel);
        Task Update(UpdateModel updateModel);
        Task<GetModel> GetById(Guid id);
        Task Delete(Guid id);
    }
}
