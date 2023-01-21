using DataModelsClassLibrary1;

namespace UserInterfaceConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Call business layer
            List<TodoItem> todos = BusinessLayerClassLibrary1.Class1.GetAllTodos();

            //User interface output
            todos.ForEach(x => Console.WriteLine(x.Name));
        }
    }
}