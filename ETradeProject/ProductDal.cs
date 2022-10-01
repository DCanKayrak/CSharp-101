using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeProject
{
    public class ProductDal // public olunca çalışmıyor.
    {
        public List<Product> GetAll()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\ProjectsV13;initial catalog=ETrade;integrated security=true");
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("SELECT * FROM Products",connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product() { 
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"])
                };
                products.Add(product);
            }

            reader.Close();
            connection.Close();
            return products;
        }

        //public DataTable GetAll2()
        //{
        //    SqlConnection connection = new SqlConnection(@"server=(localdb)\ProjectsV13;initial catalog=ETrade;integrated security=true");
        //    if (connection.State == ConnectionState.Closed)
        //    {
        //        connection.Open();
        //    }
        //    SqlCommand command = new SqlCommand("SELECT * FROM Products", connection);
        //    SqlDataReader reader = command.ExecuteReader();

        //    DataTable table = new DataTable();
        //    table.Load(reader);
        //    reader.Close();
        //    connection.Close();
        //    return table;
        //}
    }
}
