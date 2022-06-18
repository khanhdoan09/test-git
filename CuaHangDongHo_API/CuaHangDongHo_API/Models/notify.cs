namespace CuaHangDongHo_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("notify")]
    public partial class notify
    {
        [StringLength(255)]
        public string id { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        public DateTime? createAt { get; set; }
    }
}
