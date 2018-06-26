namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comments_eshop
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Comments_eshop_id { get; set; }

        public int? Uid { get; set; }

        public DateTime? Comments_eshop_date { get; set; }

        [StringLength(3800)]
        public string Comments_eshop_body { get; set; }

        public int? Comments_eshop_like { get; set; }

        public int? Comments_eshop_dislike { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Shop_id { get; set; }

        public virtual Shop Shop { get; set; }
    }
}
