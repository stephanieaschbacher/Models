using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Promotion_model.Models
{
    public class Promotion
    {
        public string PromotionID { get; set;}
        public string PromoCode { get; set; }
        public string BookID { get; set; }
        public decimal DiscountPrice { get; set; }
    }
}