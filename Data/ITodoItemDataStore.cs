using System.Collections.Generic;
using Entities;

namespace Data
{
    public interface ITodoItemDataStore
    {

        void Insert(TodoItem toInsert);
        TodoItem Get(int id);
        IEnumerable<TodoItem> GetAll();
        void Update(TodoItem saveObject);
    }
}