using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPToDoList.Services;
using ASPToDoList.Models;

namespace ASPToDoList.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IToDoItemService _toDoItemService;
        // GET: /<controller>/
        public ToDoController(IToDoItemService toDoItemService)
        {
            _toDoItemService = toDoItemService;
        }
        public async Task<IActionResult> Index()
        {
            var toDoItems = await _toDoItemService.GetIncompleteItemsAsync();
            var model = new ToDoViewModel(){ Items = toDoItems };
            return View(model);
        }
    }
}
