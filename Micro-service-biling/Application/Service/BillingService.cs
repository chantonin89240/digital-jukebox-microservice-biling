using Application.Adapter;
using Application.DTOs.Up;
using Domain.Entities;
using Domain.EntitiesContext;
using Infrastructure.Data;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class BillingService
    {
        private BilingDbContext db;
        private StripeHandler stripe;

        public BillingService(BilingDbContext dbContext, StripeHandler stripe)
        {
            db = dbContext;
            this.stripe = stripe;
        }

        public void CreateBilling(CreateBillingDtoUp dto)
        {
            Biling bill = BillingAdapter.FromCreateBillingDtoUp(dto);
            var card = dto.Card;
            var paymentMethod = stripe.CreatePaymentMethodFromCard(card.Number, card.CVC, card.ExpMonth, card.ExpYear);
            stripe.HandleBill(bill, paymentMethod);
            db.Add(bill);
        }

        public void GetUserBillings()
        {
            throw new NotImplementedException();
        }

        public void GetAllBillings()
        {
            throw new NotImplementedException();
        }
    }
}
