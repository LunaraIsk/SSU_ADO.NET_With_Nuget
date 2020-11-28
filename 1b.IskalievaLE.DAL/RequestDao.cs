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
    public class RequestDao: IRequestDao
    {
        private string connnectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=ApplicationSystem;Integrated Security=True";

        public int AddRequest(Request value)
        {
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "AddRequest";

                cmd.Parameters.Add(new SqlParameter("@DateOfCreation", value.DateOfCreation));
                cmd.Parameters.Add(new SqlParameter("@Id_Inventory", value.Id_Inventory));
                cmd.Parameters.Add(new SqlParameter("@Amount", value.Amount));
                cmd.Parameters.Add(new SqlParameter("@Comment", value.Comment));

                connection.Open();


                return (int)(decimal)cmd.ExecuteScalar();
            }
        }

        public IEnumerable<Request> GetAllRequests()
        {
            var result = new List<Request>();
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllRequests", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var request = new Request
                    {
                        IdRequest = (int)reader["IdRequest"],
                        DateOfCreation = (DateTime)reader["DateOfCreation"],
                        Id_Inventory = (int)reader["Id_Inventory"],
                        Amount = (int)reader["Amount"],
                        Comment = (string)reader["Comment"],
                    };

                    result.Add(request);
                }
            }

            return result;
        }

        public IEnumerable<Request> GetRequest(int id)
        {
            var result = new List<Request>();
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                //SqlCommand cmd = connection.CreateCommand();
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.CommandText = "GetRequest";

                //cmd.Parameters.Add(new SqlParameter("@IdRequest", id));


                SqlCommand cmd = new SqlCommand("GetRequest", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@IdRequest", id));
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var request = new Request
                    {
                        IdRequest = (int)reader["IdRequest"],
                        DateOfCreation = (DateTime)reader["DateOfCreation"],
                        Id_Inventory = (int)reader["Id_Inventory"],
                        Amount = (int)reader["Amount"],
                        Comment = (string)reader["Comment"],
                    };

                    result.Add(request);
                }
                //cmd.ExecuteNonQuery();
            }

            return result;
        }
    }
}
