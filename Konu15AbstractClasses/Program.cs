namespace Konu15AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 15 Abstract Classes");
            // Database database = new Database(); // abstract classlardan nesne üretilemez.
            Database database = new SqlServer();
            database.Add();
            database.Delete();
            database.Update();

            Database database2 = new Oracle();
            database2.Add();
            database2.Get();
            database2.Update();
        }
    }
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Add metodu çalıştı ekleme yapıldı ");
        }
        public abstract void Delete(); // crud
        public abstract void Update(); // crud
        public abstract void Get(); // crud
    }
    class SqlServer : Database
    {
        public override void Get()
        {
            Console.WriteLine("SqlServer Get metodu çalıştı Listeleme yapıldı.");
        }
        public override void Delete()
        {
            Console.WriteLine("SqlServer Delete metodu çalıştı Silme yapıldı.");
        }
        public override void Update()
        {
            Console.WriteLine("SqlServer Update metodu çalıştı Güncelleme yapıldı. ");
        }
    }
    class Oracle : Database
    {
        public override void Get()
        {
            Console.WriteLine("Oracle Get metodu çalıştı Listeleme yapıldı.");
        }
        public override void Delete()
        {
            Console.WriteLine("Oracle Delete metodu çalıştı Silme yapıldı.");
        }
        public override void Update()
        {
            Console.WriteLine("Oracle Update metodu çalıştı Güncelleme yapıldı. ");
        }
    }
    class MySql : Database
    {
        public override void Get()
        {
            Console.WriteLine("MySql Get metodu çalıştı Listeleme yapıldı.");
        }
        public override void Delete()
        {
            Console.WriteLine("MySql Delete metodu çalıştı Silme yapıldı.");
        }
        public override void Update()
        {
            Console.WriteLine("MySql Update metodu çalıştı Güncelleme yapıldı. ");
        }
    }
}
