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
        [Column("biling_id")]
        public int BilingId { get; set; }

        [Column("app_user_id")]
        public int AppUserId { get; set; }

        [Column("bar_id")]
        public int BarId { get; set; }

        [Column("price")]
        public int Price { get; set; }

        [Column("date_biling")]
        public DateTime DateBiling { get; set; }

        public Billing() { }

        public Billing(int bilingId, int appUserId, int barId,  int price, DateTime dateBiling)
        {
            this.BilingId = bilingId;
            this.AppUserId = appUserId;
            this.BarId = barId;
            this.Price = price;
            this.DateBiling = dateBiling;
        }
    }
}
