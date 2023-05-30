using Microsoft.EntityFrameworkCore;
using torneoFutbolBackendApi.Models.DataModels;

namespace torneoFutbolBackendApi.DataAccess
{
   public class DBTorneoFutbolContext: DbContext
    {
        public DBTorneoFutbolContext(DbContextOptions<DBTorneoFutbolContext> options): base(options)
        {

        }

        //  Add SbSets (Table for our Database)
        public DbSet<User> Users { get; set; }
    }
}
