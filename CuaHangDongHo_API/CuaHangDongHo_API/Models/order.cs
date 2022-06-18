namespace CuaHangDongHo_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("order")]
    public partial class order
    {
        [StringLength(255)]
        public string id { get; set; }

        [StringLength(255)]
        public string user_id { get; set; }

        [StringLength(255)]
        public string payment_method { get; set; }

        [StringLength(255)]
        public string ship { get; set; }

        [StringLength(255)]
        public string create_date { get; set; }

        [StringLength(255)]
        public string update_date { get; set; }

        [StringLength(255)]
        public string f7 { get; set; }

        [StringLength(255)]
        public string f8 { get; set; }

        [StringLength(255)]
        public string f9 { get; set; }

        [StringLength(255)]
        public string f10 { get; set; }

        [StringLength(255)]
        public string f11 { get; set; }

        [StringLength(255)]
        public string f12 { get; set; }
    }
}
