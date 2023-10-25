using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Billing
    {
        [Column("Billing_id")]
        public int BillingId { get; set; }

        [Column("app_user_id")]
        public int AppUserId { get; set; }

        [Column("bar_id")]
        public int BarId { get; set; }

        [Column("price")]
        public double Price { get; set; }

        [Column("date_Billing")]
        public DateTime DateBilling { get; set; }

        public Billing() { }

        public Billing(int BillingId, int appUserId, int barId,  int price, DateTime dateBilling)
        {
            this.BillingId = BillingId;
            this.AppUserId = appUserId;
            this.BarId = barId;
            this.Price = price;
            this.DateBilling = dateBilling;
        }
    }
}
