namespace UserInterfaceConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TodoItem todo1 = new()
            {
                Id = 1,
                Name = "Teach Computer Programming"
            };

            List<TodoItem> todos = new();
            todos.Add(todo1);

            todos.ForEach(x => Console.WriteLine(x.Name));
        }
    }

    public class TodoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Completed { get; set; }
    }
}