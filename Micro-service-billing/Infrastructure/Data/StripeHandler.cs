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
#warning does not yet use parameters, due to test environment
        public PaymentMethod CreatePaymentMethodFromCard(string Number, string CVC, int expMonth, int expYear)
        {
            var paymentMethodService = new PaymentMethodService();
            var paymentMethod = paymentMethodService.Create(new()
            {
                Type = "card",
                Card = new PaymentMethodCardOptions()
                {
                    Token = "tok_fr"
                }
            });
            return paymentMethod;
        }

        public void HandleBill(Billing bill, PaymentMethod method)
        {
            var paymentIntentService = new PaymentIntentService();
            var creationOptions = new PaymentIntentCreateOptions
            {
                Amount = (int)(bill.Price * 100),
                Currency = "eur",
                PaymentMethod = method.Id,
                AutomaticPaymentMethods = new()
                {
                    AllowRedirects = "never",
                    Enabled = true,
                }
            };
            var paymentIntent = paymentIntentService.Create(creationOptions);
            paymentIntentService.Confirm(paymentIntent.Id);
        }
    }
}
