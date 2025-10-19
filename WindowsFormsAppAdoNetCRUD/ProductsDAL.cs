using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsAppAdoNetCRUD
{
    public class ProductsDAL : OrtakDAL
    {
        public List<Product> GetAll()
        {
            var products = new List<Product>();
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("select * from Product", _connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                var product = new Product
                {
                    Id = (int)reader["Id"],
                    Name = reader["Name"].ToString(),
                    Description = reader["Description"].ToString(),
                    IsActive = Convert.ToBoolean(reader["IsActive"]),
                    CreateDate = Convert.ToDateTime(reader["CreateDate"]),
                    Stock = Convert.ToInt32(reader["Stock"]),
                    Price = Convert.ToDecimal(reader["Price"])
                };
                products.Add(product);
            }
            reader.Close();
            _connection.Close();
            sqlCommand.Dispose();

            return products;
        }

        public int Add(Product product)
        {
            int sonuc = 0;
            ConnectionControl(); // Bağlantı kontrolü yap
            SqlCommand cmd = new SqlCommand("insert into Product(Name, Description, IsActive, CreateDate, Stock, Price) values (@Name, @Description, @IsActive, @CreateDate, @Stock, @Price)",
                _connection);
            cmd.Parameters.AddWithValue("@Name", product.Name);
            cmd.Parameters.AddWithValue("@Description", product.Description);
            cmd.Parameters.AddWithValue("@IsActive", product.IsActive);
            cmd.Parameters.AddWithValue("@CreateDate", product.CreateDate);
            cmd.Parameters.AddWithValue("@Stock", product.Stock);
            cmd.Parameters.AddWithValue("@Price", product.Price);
            sonuc = cmd.ExecuteNonQuery(); // sql komutunu çalıştırır ve etkilenen kayıt sayısını sonuca atar.
            cmd.Dispose(); // komut nesnesini bellekten atar
            _connection.Close(); // bağlantıyı kapatır
            return sonuc;
        }
        public int Update(Product product)
        {
            int sonuc = 0;
            ConnectionControl(); // bağlantI kontrolü yap
            SqlCommand cmd = new SqlCommand("update Product set Name=@Name, Description=@Description, IsActive=@IsActive, CreateDate=@CreateDate, Stock=@Stock, Price=@Price where Id=@Id", _connection);
            cmd.Parameters.AddWithValue("@Name", product.Name);
            cmd.Parameters.AddWithValue("@Description", product.Description);
            cmd.Parameters.AddWithValue("@IsActive", product.IsActive);
            cmd.Parameters.AddWithValue("@CreateDate", product.CreateDate);
            cmd.Parameters.AddWithValue("@Stock", product.Stock);
            cmd.Parameters.AddWithValue("@Price", product.Price);
            cmd.Parameters.AddWithValue("@Id", product.Id);
            sonuc = cmd.ExecuteNonQuery(); // sql komutunu çalıştır ve etkilenen kayıt sayısını sonuc a ata
            cmd.Dispose();
            _connection.Close();
            return sonuc;
        }
        public int Delete(int id)
        {
            int sonuc = 0;
            ConnectionControl(); // bağlanto kontrolü yap
            SqlCommand cmd = new SqlCommand("delete from Product where Id=@Id", _connection);
            cmd.Parameters.AddWithValue("@Id", id);
            sonuc = cmd.ExecuteNonQuery(); // sql komutunu çalıştır ve etkilenen kayıt sayısını sonuc a ata
            cmd.Dispose();
            _connection.Close();
            return sonuc;
        }
    }
}
