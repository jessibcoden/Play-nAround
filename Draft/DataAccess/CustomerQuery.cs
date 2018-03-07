using Draft.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft.DataAccess
{
    class CustomerQuery
    {

        readonly string _connectionString = ConfigurationManager.ConnectionStrings["BladeRunners"].ConnectionString;

        public List<Customer> GetAllCustomers()
        {

            using (var connection = new SqlConnection(_connectionString))
            {

                var cmd = connection.CreateCommand();

                cmd.CommandText = @"select *
                                    from Customers c
                                    order by c.LastName";

                connection.Open();
                var reader = cmd.ExecuteReader();

                var allCustomers = new List<Customer>();

                while (reader.Read())
                {
                    var customer = new Customer
                    {
                        CustomerId = int.Parse(reader["CustomerId"].ToString()),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString()
                    };

                    allCustomers.Add(customer);
                }

                return allCustomers;

            }
        }

    }
}
