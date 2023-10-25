using Application.Adapter;
using Application.DTOs.Up;
using Domain.Entities;
using Domain.EntitiesContext;
using Infrastructure.Data;
using Stripe;

namespace Application.Service
{
    public class BillingService
    {
        private BillingDbContext db;
        private StripeHandler stripe;

        public BillingService(BillingDbContext dbContext, StripeHandler stripe)
        {
            db = dbContext;
            this.stripe = stripe;
        }

        public void CreateBilling(CreateBillingDtoUp dto)
        {
            Billing bill = BillingAdapter.FromCreateBillingDtoUp(dto);
            stripe.CreateIntentFromBill(bill);
        }

        public void HandleStripeEvent(Event e)
        {
            switch (e.Type)
            {
                case Events.PaymentIntentSucceeded:
                    PaymentIntent intent = e.Data.Object as PaymentIntent;
                    if (intent.Metadata.ContainsKey("AppUserId") && intent.Metadata.ContainsKey("BarId")) //if not, the data is insufficient for this DB.
                    {
                        Billing bill = BillingAdapter.FromStripePaymentIntent(intent);
                        db.Add(bill);
                    }
                    break;
            }
        }

        public IEnumerable<Billing> GetUserBillings()
        {
            throw new NotImplementedException();
        }

        public double GetAllBillings()
        {
            throw new NotImplementedException();
        }
    }
}

