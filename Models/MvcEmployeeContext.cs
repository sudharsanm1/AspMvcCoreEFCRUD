using Microsoft.EntityFrameworkCore;  

namespace MvcEfCRUD.Models  
{  
    public class MvcEmployeeContext : DbContext  
    {  
        public MvcEmployeeContext (DbContextOptions<MvcEmployeeContext> options)  
            : base(options)  
        {  
        }  

        public DbSet<MvcEfCRUD.Models.Employees> Employee { get; set; }  
    }  
}