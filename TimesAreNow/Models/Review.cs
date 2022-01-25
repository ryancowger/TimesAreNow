namespace TimesAreNow.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Review")]
    public partial class Review
    {
        public int ReviewId { get; set; }

        [Required]
        [StringLength(128)]
        public string CustomerId { get; set; }

        public int ProductId { get; set; }

        public short StarRating { get; set; }

        public string Comment { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }
    }
}
