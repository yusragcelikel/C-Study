using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {

        SqlConnection _connection = new SqlConnection(@"server = (localdb) \ mssplllocaldb; initial catalog = ETrade; integrated security = true");


        public List<Product> GetAll()
        {
            ConnectionControl();

            SqlCommand cmd = new SqlCommand("Select * from Products", _connection);

            SqlDataReader reader = cmd.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product()
                {

                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    // her okunan eleman product a aktarılır
                };

                products.Add(product); // product a aktarılanları listeye ekler

            }

            reader.Close();
            _connection.Close();

            return products;

        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed) // bağlantıyı kapalıysa aç
            {
                _connection.Open();
            }
        }

        public DataTable GetAll2()
        {

            if (_connection.State == ConnectionState.Closed) // bağlantıyı kapalıysa aç
            {
                _connection.Open();

            }

            SqlCommand cmd = new SqlCommand("Select * from Products", _connection);

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();

            return dataTable;


        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Products values(@name, @unitPrice, @stockAmount)", _connection);


            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.ExecuteNonQuery();

            _connection.Close();

        }

        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Products set Name = @name, UnitPrice = @unitPrice, StockAmount = @stockAmount where Id = @id", _connection);


            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();

            _connection.Close();

        }

        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Products where Id = @id", _connection);
            
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            _connection.Close();

        }

    }
}
