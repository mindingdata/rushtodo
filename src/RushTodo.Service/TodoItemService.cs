using RushTodo.Data;
using RushTodo.Domain.Aggregates;
using RushTodo.Service.Interfaces;
using RushTodo.Service.Models.TodoItem;
using System;
using System.Threading.Tasks;

namespace RushTodo.Service
{
    public class TodoItemService : ITodoItemService
    {
        private readonly ITodoItemRepository _todoItemRepository;

        public TodoItemService(ITodoItemRepository todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }

        public async Task<GetModel> Create(CreateModel createModel)
        {
            var todoItem = new TodoItem(createModel.Description, createModel.DueDate);
            await _todoItemRepository.Save(todoItem);
            return new GetModel
            {
                Id = todoItem.Id,
                Description = todoItem.Description,
                DueDate = todoItem.DueDate
            };
        }

        public async Task Update(UpdateModel updateModel)
        {
            var existingItem = await _todoItemRepository.GetById(updateModel.Id);
            existingItem.UpdateDetails(updateModel.Description, updateModel.DueDate);
            await _todoItemRepository.Save(existingItem);
        }

        public async Task<GetModel> GetById(Guid id)
        {
            var todoItem = await _todoItemRepository.GetById(id);
            return new GetModel
            {
                Id = todoItem.Id,
                Description = todoItem.Description,
                DueDate = todoItem.DueDate
            };
        }

        public async Task Delete(Guid id)
        {
            var todoItem = await _todoItemRepository.GetById(id);
            todoItem.Delete();
            await _todoItemRepository.Save(todoItem);
        }
    }
}
