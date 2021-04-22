using Microsoft.EntityFrameworkCore;

namespace PaymentApi.Models
{
    public class PaymentDbContext :DbContext
    {
        public PaymentDbContext(DbContextOptions<PaymentDbContext> options):base(options)
        {
            
        }

        public DbSet<PaymentDetails> PaymentDetails { get; set; }
        
    }
}