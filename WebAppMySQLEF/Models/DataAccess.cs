using System.Data.Entity;

namespace WebAppMySQLEF.Models
{
   [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
   public class DataAccess : DbContext
   {
      static DataAccess()
      {
         DbConfiguration.SetConfiguration(new MySql.Data.Entity.MySqlEFConfiguration());
      }
      public DataAccess(string connStringName) : base(connStringName) { }
      public DataAccess() : this("MyDB") { }

      public DbSet<Client> Client { get; set; }
      
   }
}