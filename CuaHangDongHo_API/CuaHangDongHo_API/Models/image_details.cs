namespace CuaHangDongHo_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class image_details
    {
        [Key]
        [StringLength(255)]
        public string img_id { get; set; }

        [StringLength(255)]
        public string img_url { get; set; }

        [StringLength(255)]
        public string product_id { get; set; }

        public virtual product product { get; set; }
    }
}
