using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("Billing")]
    public class BillingController : Controller
    {
        public BillingController() { }

        /// <summary>
        /// Creates a Billing
        /// </summary>
        [Route("/Create")]
        [HttpPost]
        public void CreateBilling() { 
            
        }
    }
}
