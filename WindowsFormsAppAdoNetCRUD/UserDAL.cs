using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppAdoNetCRUD
{
    internal class UserDAL : OrtakDAL
    {
        public int Add(User user)
        {
            int sonuc = 0;
            ConnectionControl(); 
            SqlCommand cmd = new SqlCommand("insert into Users(Name, Surname, Password, Email, IsActive, CreateDate) values (@Name, @Surname, @Password, @Email, @IsActive, @CreateDate)",
                _connection);
            cmd.Parameters.AddWithValue("@Name", user.Name);
            cmd.Parameters.AddWithValue("@Surname", user.Surname);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@IsActive", user.IsActive);
            cmd.Parameters.AddWithValue("@CreateDate", user.CreateDate);
            sonuc = cmd.ExecuteNonQuery(); 
            cmd.Dispose(); 
            _connection.Close(); 
            return sonuc;
        }
        public int Update(User user)
        {
            int sonuc = 0;
            ConnectionControl(); 
            SqlCommand cmd = new SqlCommand("update Users set Name=@Name, Surname=@Surname, Password=@Password, Email=@Email, IsActive=@IsActive, CreateDate=@CreateDate where Id=@Id", _connection);
            cmd.Parameters.AddWithValue("@Name", user.Name);
            cmd.Parameters.AddWithValue("@Surname", user.Surname);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@IsActive", user.IsActive);
            cmd.Parameters.AddWithValue("@CreateDate", user.CreateDate);
            cmd.Parameters.AddWithValue("@Id", user.Id);
            sonuc = cmd.ExecuteNonQuery(); 
            cmd.Dispose();
            _connection.Close();
            return sonuc;
        }
        public int Delete(int id)
        {
            int sonuc = 0;
            ConnectionControl(); // bağlanto kontrolü yap
            SqlCommand cmd = new SqlCommand("delete from users where Id=@Id", _connection);
            cmd.Parameters.AddWithValue("@Id", id);
            sonuc = cmd.ExecuteNonQuery(); // sql komutunu çalıştır ve etkilenen kayıt sayısını sonuc a ata
            cmd.Dispose();
            _connection.Close();
            return sonuc;
        }
    }
}
