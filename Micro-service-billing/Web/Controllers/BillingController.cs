using Application.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Application.DTOs.Up;

namespace Web.Controllers
{
    [Route("Billing")]
    public class BillingController : Controller
    {
        private BillingService service;
        public BillingController(BillingService billingService) { service = billingService; }

#warning Cannot get user without auth!

        /// <summary>
        /// Creates a Billing
        /// </summary>
        [Route("Create")]
        [HttpPost]
        public ActionResult CreateBilling([FromBody] CreateBillingDtoUp billing) 
        {
            try
            {
                service.CreateBilling(billing);
            }catch (Exception ex)
            {
                return StatusCode(500, "internal server error occurred: " + ex.Message);
            }
            return Ok(billing);
        }

        [Route("/")]
        [HttpGet]
        /// <summary>
        /// Gets a list of bills made by a user.
        /// </summary>
        /// <returns>Currently, "Not Found" - Cannot get user without authentication.</returns>
        public ActionResult GetUserBillings()
        {
            return NotFound();
        }

        [Route("Total")]
        [HttpGet]
        /// <summary>
        /// Gets the total of all bills
        /// </summary>
        /// <returns></returns>
        [Authorize(AuthenticationSchemes = "Bearer", Roles = "ProjectOwner")]
        public ActionResult GetBillingsTotal()
    {
            return Ok();
        }
    }
}
