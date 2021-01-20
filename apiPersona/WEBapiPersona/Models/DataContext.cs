namespace WEBapiPersona.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<WEBapiPersona.Models.Person> People { get; set; }
    }
}