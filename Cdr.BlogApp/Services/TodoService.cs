using Cdr.BlogApp.Models;

namespace Cdr.BlogApp.Services
{
    public class TodoService : ITodoService
    {
        private static List<TodoItem> todos;
        public TodoService()
        {
            todos = new List<TodoItem>
            {
                new TodoItem{Id=1,Title="Market alışverişi",IsDone=false},
                new TodoItem{Id=2,Title="Spora gidilecek",IsDone=true},
                new TodoItem{Id=3,Title="Araba yıkamadan alınacak",IsDone=false},
            };
        }
        public void Add(TodoItem todoItem)
        {
            todos.Add(todoItem);
        }

        public void Delete(int id)
        {
            todos.Remove(todos.Find(t => t.Id == id));
        }

        public TodoItem GetById(int id)
        {
            return todos.FirstOrDefault(t => t.Id == id);
        }

        public List<TodoItem> GetList()
        {
            return todos;
        }

        public void Update(TodoItem todoItem)
        {
            var data = todos.FirstOrDefault(t => t.Id == todoItem.Id);
            if (data != null)
            {
                data.Title = todoItem.Title;
                data.IsDone = todoItem.IsDone;
            }
        }
    }
}
