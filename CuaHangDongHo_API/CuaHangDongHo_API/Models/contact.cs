namespace CuaHangDongHo_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("contact")]
    public partial class contact
    {
        [StringLength(255)]
        public string id { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(999)]
        public string message { get; set; }

        public DateTime? createdAt { get; set; }
    }
}
