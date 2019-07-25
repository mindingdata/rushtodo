using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RushTodo.Service.Interfaces;
using RushTodo.Service.Models.TodoItem;
using RushTodo.Web.Models.Todo;

namespace RushTodo.Web.Controllers
{
    [Route("")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        [HttpGet("{id}")]
        public async Task<Models.GetModel> Get(Guid id)
        {
            var item = await _todoItemService.GetById(id);

            return new Models.GetModel
            {
                Description = item.Description,
                DueDate = item.DueDate,
                Id = item.Id
            };
        }

        [HttpPost]
        public async Task<Models.GetModel> Post([FromBody] PostModel model)
        {
            var item = await _todoItemService.Create(new CreateModel
            {
                Description = model.Description, 
                DueDate = model.DueDate
            });

            return new Models.GetModel
            {
                Description = item.Description,
                DueDate = item.DueDate,
                Id = item.Id
            };
        }

        [HttpPut("{id}")]
        public async Task Put(Guid id, [FromBody] PutModel model)
        {
            await _todoItemService.Update(new UpdateModel
            {
                Id = id,
                Description = model.Description,
                DueDate = model.DueDate
            });
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _todoItemService.Delete(id);
        }
    }
}
