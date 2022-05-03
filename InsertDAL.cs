using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using AdoMVC1.Models;
using System.Data.SqlClient;
using System.IO;
using System.Data;
namespace AdoMVC1.DAL
{
    public class InsertDAL
    {
        public string cnn = "";


        public InsertDAL()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                  (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            cnn = builder.GetSection("ConnectionStrings:Conn").Value;
        }
        public void InsDal(int sno, string cname, string email, string mob) 
        {

            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("NewCustomer", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@sno", SqlDbType.Int).Value = sno;
            cmd.Parameters.Add("@cname", SqlDbType.VarChar).Value = cname;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@mob", SqlDbType.VarChar).Value = mob;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}