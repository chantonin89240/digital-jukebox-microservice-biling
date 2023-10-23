using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class StripeHandler
    {

        public PaymentIntent CreateIntentFromBill(Billing bill)
        {
            var paymentIntentService = new PaymentIntentService();

            IEnumerable<KeyValuePair<string, string>> Metadata = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("AppUserId",bill.AppUserId.ToString()),
                new KeyValuePair<string, string>("BarId",bill.BarId.ToString())
            };

            var creationOptions = new PaymentIntentCreateOptions
            {
                Amount = (int)(bill.Price * 100),
                Currency = "eur",
                AutomaticPaymentMethods = new()
                {
                    AllowRedirects = "never",
                    Enabled = true,
                },
                Metadata = new(Metadata)
            };
            
            return paymentIntentService.Create(creationOptions);
        }
    }
}
