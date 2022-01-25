namespace TimesAreNow.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Purchase")]
    public partial class Purchase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Purchase()
        {
            PurchaseLineItems = new HashSet<PurchaseLineItem>();
        }

        public int PurchaseId { get; set; }

        [Required]
        [StringLength(128)]
        public string CustomerId { get; set; }

        [StringLength(500)]
        public string ShippingAddress { get; set; }

        public DateTime? CompletedDate { get; set; }

        public bool IsCompleted { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseLineItem> PurchaseLineItems { get; set; }
    }
}
