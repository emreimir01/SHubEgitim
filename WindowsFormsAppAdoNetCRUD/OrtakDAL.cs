using System.Data; // Veritabanı işlemleri için gerekli kütüphane
using System.Data.SqlClient; // SQL Server bağlantısı için gerekli ado.net kütüphanesi


namespace WindowsFormsAppAdoNetCRUD
{
    public class OrtakDAL
    {
        internal SqlConnection _connection = new SqlConnection(@"server= (localdb)\MSSQLLocalDB; 
            database= WindowsFormsAppAdoNetCRUD; Integrated Security=True;");

        internal void ConnectionControl() // Bağlantı kontrol metodu
        {
            if (_connection.State == ConnectionState.Closed) // Eğer bağlantı kapalı ise
            {
                _connection.Open(); // Bağlantıyı aç
            }
        }
        public DataTable GetDataTable(string sqlSorgu)
        {
            DataTable dt = new DataTable(); // Sonuçları tutacak DataTable nesnesi
            ConnectionControl(); // Bağlantı kontrolü yap

            SqlCommand command = new SqlCommand(sqlSorgu, _connection); // SQL komutunu oluştur

            SqlDataReader reader = command.ExecuteReader(); // Komutu çalıştır ve sonuçları oku

            dt.Load(reader); // Sonuçları DataTable'a yükle

            reader.Close(); // Okuyucuyu kapat
            _connection.Close(); // Bağlantıyı kapat
            command.Dispose(); // Komut nesnesini bellekten at


            return dt; // Sonuçları döndür
        }

    }
}
