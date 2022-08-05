using Cdr.BlogApp.Models;

namespace Cdr.BlogApp.Services
{
    public interface ITodoService
    {
        List<TodoItem> GetList();
        TodoItem GetById(int id);
        void Delete(int id);
        void Add(TodoItem todoItem);

        void Update(TodoItem todoItem);
    }
}
