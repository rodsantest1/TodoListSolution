using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModelsClassLibrary1
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Completed { get; set; }
    }
}
