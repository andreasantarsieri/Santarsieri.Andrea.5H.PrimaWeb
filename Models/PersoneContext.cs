using Microsoft.EntityFrameworkCore;

namespace Santarsieri.Andrea._5H.PrimaWeb.Models
{
    public class PersoneContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<Persona> Persone {get;set;}

        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder opzioni)
        {
            opzioni.UseSqlite("Data Source=DbPersone.db");
        }
    }
}