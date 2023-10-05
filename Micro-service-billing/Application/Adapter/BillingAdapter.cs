using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.Up;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Application.Adapter
{
    /// <summary>
    /// Adapts various DTOs and Request data into Domain "Billing" Entity.
    /// </summary>
    public static class BillingAdapter
    {
#warning Must include user from authentication, which is not yet handled.
        public static Billing FromCreateBillingDtoUp(CreateBillingDtoUp DTO)
        {
            return new Billing
            {
                Price = DTO.Amount,
                BarId = DTO.BarIdentifier
            };
        }
    }
}
