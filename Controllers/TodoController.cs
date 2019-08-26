using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TodoApi.Models;
using System;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : Controller
    {
        private readonly TodoContext _context;

        public TodoController(TodoContext context)
        {
            _context = context;

            if (_context.TodoItems.Count() == 0)
            {
                _context.TodoItems.Add(new TodoItem { Name = "Item1" });
                _context.SaveChanges();
            }
        }

        // create a form which posts to an endpoint on the server - done
        // send a name attribute from the form to the server - done
        // persist a new todo item to the database 

            // /api/todo
        [HttpGet]
        public ActionResult<string> GetAll()
        {
            var items = _context.TodoItems.ToList();
            return View(items);
        }
         // /api/todo/<id>
        [HttpGet("{id}", Name = "GetTodo")]
        public ActionResult<TodoItem> GetById(long id)
        {
            var item = _context.TodoItems.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
        // /api/todo
        [HttpPost]
        public ActionResult<string> NewToDoItem([FromForm] string name)
        {
            _context.TodoItems.Add(new TodoItem { Name = name });
            _context.SaveChanges();
            return Redirect("/api/todo");
        }
    }
}
