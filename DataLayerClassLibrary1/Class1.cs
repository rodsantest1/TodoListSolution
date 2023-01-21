using DataModelsClassLibrary1;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
//using Newtonsoft.Json;
using System.Data;
using System.Text.Json;

namespace DataLayerClassLibrary1
{
    public class Class1
    {
        public static List<TodoItem> GetAllTodos()
        { 
            var connString = @"Server=(localdb)\MSSQLLocalDB;Database=Database1;Trusted_Connection=True;";

            var dt = new DataTable();

            List<TodoItem> todos = new List<TodoItem>();

            using (var con = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand(
                  "SELECT * FROM Todo",
                  con);
                con.Open();

                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    //var serializedMyObjects = JsonConvert.SerializeObject(dt);
                    //// Here you get the object
                    //todos = (List<TodoItem>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<TodoItem>));

                    var serializedMyObjects = JsonSerializer.Serialize(dt);
                    // Here you get the object
                    todos = JsonSerializer.Deserialize<List<TodoItem>>(serializedMyObjects);
                }

                con.Close();
            }

            return todos;
        }
    }
}