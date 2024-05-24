using MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace MVC.Data{
    public class ApplicationDbcontext : DbContext{
        internal readonly object Student;

        public ApplicationDbcontext()
        {
            
        }
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {}
    
        public DbSet<Customer> Customer { get; set;}
        public DbSet<DaiLy> DaiLy { get; set;}
        public DbSet<HeThongPhanPhoi> HeThongPhanPhoi { get; set;}
        public DbSet<Student> Students { get; set;}
        
    }
}