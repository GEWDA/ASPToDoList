using ASPToDoList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPToDoList.Services
{
    public class FakeToDoItemService : IToDoItemService
    {
        public Task<IEnumerable<ToDoItem>> GetIncompleteItemsAsync()
        {
            IEnumerable<ToDoItem> items = new[]
            {
                new ToDoItem{Title="Learn ASP.NET Core",DueAt=DateTimeOffset.Now.AddDays(1)},
                new ToDoItem {Title="Build Awesome Apps",DueAt=DateTimeOffset.Now.AddDays(2)}
            };

            return Task.FromResult(items);
        }
    }
}
