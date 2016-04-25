using System.Collections.Generic;
using System.Web.Http;
using Entities;
using Services;

namespace SimpleToDo_Angular_WebApi.Controllers
{
    public class TodoItemController : ApiController
    {

        private readonly TodoItemRepository _todoItemRepository;


        public TodoItemController(TodoItemRepository todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }


        // GET api/<controller>
        public IEnumerable<TodoItem> Get()
        {
            return _todoItemRepository.GetAll();
        }

        // GET api/<controller>/5
        public TodoItem Get(int id)
        {
            return _todoItemRepository.Get(id);
        }

        // POST api/<controller>
        public int PostTodoItem(TodoItem todoItem)
        {
           return _todoItemRepository.Save(todoItem);

        }

        // PUT api/<controller>/5
        public void PutItem(int id, TodoItem item)
        {
            _todoItemRepository.Save(item);
        }     
    }
}