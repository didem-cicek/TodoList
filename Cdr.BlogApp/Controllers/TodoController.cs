using Cdr.BlogApp.Models;
using Cdr.BlogApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cdr.BlogApp.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoService todoService;

        public TodoController(ITodoService todoService)
        {
            this.todoService = todoService;
        }
        public IActionResult Index()
        {
            return View(todoService.GetList());
        }
        public IActionResult Detail(int id)
        {
            return View(todoService.GetById(id));
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TodoItem item)
        {
            todoService.Add(item);
            //return View("index",todoService.GetList());
            //https://localhost:xxx/todo/create



            return RedirectToAction("Index");    //https://localhost:xxx/todo/index
        }
        #region Alternatif HTTPPOST Action
        //[HttpPost]
        //public IActionResult Create(string title,int id,bool isDone)
        //{
        //    var item = new TodoItem
        //    {
        //        Id = id,
        //        Title = title,
        //        IsDone = isDone
        //    };
        //    todoService.Add(item);
        //    return View("index");
        //} 
        #endregion


        public IActionResult Delete(int id)
        {
            TodoItem item = todoService.GetById(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            todoService.Delete(id);
            return RedirectToAction("index");
        }

        public IActionResult Edit(int id, string title, bool isdone)
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Edit(TodoItem item)
        {
            todoService.Update(item);
            return RedirectToAction("index");
        }
    }
}
