using System.Collections.Generic;
using System.Linq;
using Entities;

namespace Data
{
    public class InMemoryTodoItemDataStore : ITodoItemDataStore
    {
        private List<TodoItem> _store;
        private int _indexCounter;

        public InMemoryTodoItemDataStore()
        {
            _store = new List<TodoItem>();
            _indexCounter = 0;
         
        }


        private int GetNextId()
        {
           return _indexCounter++;
        }


        public void Insert(TodoItem toInsert)
        {
            toInsert.Id = GetNextId();

            _store.Add(toInsert);
        }

        public TodoItem Get(int id)
        {
            return _store.FirstOrDefault(item => item.Id == id);
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return _store;
        }

        public void Update(TodoItem saveObject)
        {
            _store.RemoveAll(t => t.Id == saveObject.Id);
            _store.Add(saveObject);
           _store = _store.OrderBy(s => s.Id).ToList();
        }
    }
}