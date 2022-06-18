namespace CuaHangDongHo_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("user")]
    public partial class user
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string full_name { get; set; }

        [StringLength(255)]
        public string gender { get; set; }

        [StringLength(255)]
        public string birthday { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        [StringLength(255)]
        public string avatar { get; set; }

        [StringLength(255)]
        public string phone { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        [StringLength(255)]
        public string role { get; set; }

        [StringLength(255)]
        public string create_date { get; set; }

        [StringLength(255)]
        public string update_date { get; set; }
    }
}
