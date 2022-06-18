namespace CuaHangDongHo_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("brand")]
    public partial class brand
    {
        [Key]
        [StringLength(255)]
        public string brand_id { get; set; }

        [StringLength(255)]
        public string brand_name { get; set; }
    }
}
