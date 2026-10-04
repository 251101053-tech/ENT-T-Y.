using System;
using System.Data.Entity;

namespace saner3
{
    public class sanerEntities : DbContext
    {
        public sanerEntities() : base(@"Data Source=DESKTOP-63KCJ7O\SQLEXPRESS;Initial Catalog=Ray;Integrated Security=True;")
        {
        }

        public DbSet<RAY> RAY { get; set; }
    }
}