using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.DTOs.Up;

namespace Application.Adapter
{
    /// <summary>
    /// Adapts various DTOs and Request data into Domain "Billing" Entity.
    /// </summary>
    public static class BillingAdapter
    {
#warning Must include user from authentication. Not yet handled.
        public static Biling FromCreateBillingDtoUp(CreateBillingDtoUp DTO)
        {
            return new Biling
            {
                Price = DTO.Amount,
            };
        }
    }
}
