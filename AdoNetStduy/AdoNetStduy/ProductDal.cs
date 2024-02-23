using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetStduy
{
    public class ProductDal
    {
        // @: hepsini string algılar.
        // initial catalog: hangi veri tabanına bağlanılacağını algılar. 
        // integrated security: uzaktaki veri tabanına bağlanmak istenildiğinde false yazılır. 

        SqlConnection _connection = new SqlConnection(@"server = (localdb)\MSSQLLocalDB; initial catalog = ETrade; integrated security = true");

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed) // Eğer bağlantı kapalıysa açılır
            {
                _connection.Open();
            }
        }

        public List<Product> GetAll() // GetAll metodu ürünleri listeler
        {
            ConnectionControl();

            //Etrade üstüne gelip New Query basıldığında sql kodları yazılır.

            SqlCommand command = new SqlCommand("Select * from Products", _connection);

            // Komudu connection'a yolladık. Burada sadece komut oluştu çalıştırılmadı.

            SqlDataReader reader = command.ExecuteReader(); // Bu kod ile komut çalıştırılır. 

            // Tablo komudunu çalıştırmak istediğimiz için ExecuteReader yazılır.

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["ID"]),
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


        // DataTable çok kullanılmaz
        public DataTable GetAll2() 
        {
            ConnectionControl();
          
            SqlCommand command = new SqlCommand("Select * from Products", _connection);


            SqlDataReader reader = command.ExecuteReader(); 

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

            SqlCommand command = new SqlCommand(
                "UPDATE Products SET Name=@name, UnitPrice=@unitPrice, StockAmount=@stockAmount WHERE Id=@id", _connection);

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

            SqlCommand command = new SqlCommand(
                "DELETE FROM Products WHERE Id=@id", _connection);
    
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
