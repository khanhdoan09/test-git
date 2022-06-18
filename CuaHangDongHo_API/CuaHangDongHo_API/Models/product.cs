namespace CuaHangDongHo_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("product")]
    public partial class product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product()
        {
            image_details = new HashSet<image_details>();
        }

        [Key]
        [StringLength(255)]
        public string product_id { get; set; }

        [StringLength(255)]
        public string product_name { get; set; }

        [StringLength(255)]
        public string avatar { get; set; }

        public int? price { get; set; }

        public int? discount { get; set; }

        public int? import { get; set; }

        public int? stock { get; set; }

        [StringLength(255)]
        public string brand_id { get; set; }

        [StringLength(255)]
        public string gender { get; set; }

        [StringLength(255)]
        public string origin { get; set; }

        [StringLength(255)]
        public string warranty_period { get; set; }

        [StringLength(255)]
        public string diameter { get; set; }

        [StringLength(255)]
        public string material { get; set; }

        [StringLength(255)]
        public string strap { get; set; }

        [StringLength(255)]
        public string wire_width { get; set; }

        [StringLength(255)]
        public string apparatus { get; set; }

        [StringLength(255)]
        public string waterproof { get; set; }

        [StringLength(2000)]
        public string description { get; set; }

        [Column(TypeName = "date")]
        public DateTime? create_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? update_date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<image_details> image_details { get; set; }
    }
}
