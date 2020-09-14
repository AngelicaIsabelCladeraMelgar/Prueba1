

namespace Prueba1.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base ("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Prueba1.Models.Cladera> Claderas { get; set; }
    }
}