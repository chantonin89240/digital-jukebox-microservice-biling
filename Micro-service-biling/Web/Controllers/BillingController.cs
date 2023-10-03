using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web.DTOs.Up;

namespace Web.Controllers
{
    [Route("Billing")]
    public class BillingController : Controller
    {
        public BillingController() { }

#warning Cannot get user without auth!

        /// <summary>
        /// Creates a Billing
        /// </summary>
        [Route("/Create")]
        [HttpPost]
        public ActionResult CreateBilling([FromBody] CreateBillingDtoUp billing) 
        {

            return Ok(billing);
        }

        /// <summary>
        /// Gets a list billing made by a user.
        /// </summary>
        /// <returns>Currently, "Not Found" - Cannot get user without authentication.</returns>
        public ActionResult GetUserBillings()
        {
            return NotFound();
        }

        /// <summary>
        /// Gets
        /// </summary>
        /// <returns></returns>
        [Authorize(AuthenticationSchemes = "Bearer", Roles = "ProjectOwner")]
        public ActionResult GetBillingsTotal()
        {
            return Ok();
        }
    }
}
