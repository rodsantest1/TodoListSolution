using DataModelsClassLibrary1;

namespace BusinessLayerClassLibrary1
{
    public class Class1
    {
        public static List<TodoItem> GetAllTodos()
        {
            var todos = DataLayerClassLibrary1.Class1.GetAllTodos();

            return todos;
        }
    }
}