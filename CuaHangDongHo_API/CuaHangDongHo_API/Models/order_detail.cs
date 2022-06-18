namespace CuaHangDongHo_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class order_detail
    {
        [StringLength(255)]
        public string id { get; set; }

        [StringLength(255)]
        public string order_id { get; set; }

        [StringLength(255)]
        public string product_id { get; set; }

        [StringLength(255)]
        public string quantity { get; set; }

        [StringLength(255)]
        public string order_date { get; set; }
    }
}
