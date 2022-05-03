using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using Microsoft.Extensions.Configuration;
using AdoMVC1.Models;
namespace AdoMVC1.DAL
{
    public class CustomerDAL
    {
        public string cnn = "";


        public CustomerDAL()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            cnn = builder.GetSection("ConnectionStrings:Conn").Value;
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> listCustomer = new List<Customer>();
            using (SqlConnection con = new SqlConnection(cnn))
            {
                using (SqlCommand cmd = new SqlCommand("GetAllCustomers", con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listCustomer.Add(new Customer()
                        {
                            CustomerID = int.Parse(reader["CustomerID"].ToString()),
                            CustomerName = reader["CustomerName"].ToString(),
                            EmailID = reader["EmailID"].ToString(),
                            MobileNo = reader["MobileNo"].ToString()
                        }); ;
                    }

                }
            }
            return listCustomer;
        }
    }
}