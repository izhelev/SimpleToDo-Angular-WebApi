using System.Collections.Generic;
using Data;
using Entities;

namespace Services
{
    public class TodoItemRepository
    {
        private readonly ITodoItemDataStore _dataStore;

        public TodoItemRepository(ITodoItemDataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public int Save(TodoItem item)
        {
            if (item.Id == 0)
            {
                _dataStore.Insert(item);
            }
            else
            {
                _dataStore.Update(item);
            }

            return item.Id;
        }

        public IEnumerable<TodoItem> GetAll()
        {
          return  _dataStore.GetAll();
        }

        public TodoItem Get(int id)
        {
            return _dataStore.Get(id);
        }
    }
}
