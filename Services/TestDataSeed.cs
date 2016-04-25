using Data;
using Entities;

namespace Services
{
    public class TestDataSeed
    {
        private readonly ITodoItemDataStore _dataStore;

        public TestDataSeed(ITodoItemDataStore dataStore)
        {
            _dataStore = dataStore;
            SeedSomeTestData();
        }


        private void SeedSomeTestData()
        {
            _dataStore.Insert(new TodoItem() { Id = 1, Title = "Item 1", Completed = true });
            _dataStore.Insert(new TodoItem() { Id = 2, Title = "Item 2", Completed = false });
            _dataStore.Insert(new TodoItem() { Id = 3, Title = "Item 4", Completed = false });
        }

    }
}
