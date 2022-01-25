namespace TimesAreNow.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PurchaseLineItem")]
    public partial class PurchaseLineItem
    {
        [Key]
        public int LineItemId { get; set; }

        public int PurchaseId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public virtual Product Product { get; set; }

        public virtual Purchase Purchase { get; set; }
    }
}
