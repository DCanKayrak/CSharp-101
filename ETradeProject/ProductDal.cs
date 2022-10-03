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
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\ProjectsV13;initial catalog=ETrade;integrated security=true");
        public void Add(Product product)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("INSERT INTO Products VALUES(@name,@unitPrice,@stockAmount)",_connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);

            command.ExecuteNonQuery();
            _connection.Close();

        }
        public void Update(Product product)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Update Products set Name=@name, UnitPrice = @unitPrice, StockAmount = @stockAmount where ID =@id", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();

            _connection.Close();
        }
        public void Delete(int productId)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("DELETE FROM Products WHERE id = @id", _connection);
            command.Parameters.AddWithValue("@id", productId);
            command.ExecuteNonQuery();

            _connection.Close();
        }
        public List<Product> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("SELECT * FROM Products", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"])
                };
                products.Add(product);
            }

            reader.Close();
            _connection.Close();
            return products;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
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
