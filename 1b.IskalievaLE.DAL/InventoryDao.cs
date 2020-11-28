using _1b.IskalievaLE.DAL.Interface;
using _1b.IskalievaLE.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1b.IskalievaLE.DAL
{
    public class InventoryDao: IInventoryDao
    {
        private string connnectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=ApplicationSystem;Integrated Security=True";

        public IEnumerable<Inventory> GetAllInventory()
        {
            var result = new List<Inventory>();
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllInventory", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var inventory = new Inventory
                    {
                        IdInventory = (int)reader["IdInventory"],
                        Name = (string)reader["Name"]
                    };

                    result.Add(inventory);
                }
            }

            return result;
        }

    }
}
