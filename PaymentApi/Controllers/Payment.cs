using Microsoft.AspNetCore.Mvc;
using PaymentApi.Models;

namespace PaymentApi.Controllers
{
    
    public class Payment : ControllerBase
    {
        private PaymentDbContext _context;

        public Payment(PaymentDbContext context)
        {
            _context = context;
        }
        // GET
        public IActionResult Index()
        {
            var data = _context.PaymentDetails;
            return Ok(data);
        }
    }
}