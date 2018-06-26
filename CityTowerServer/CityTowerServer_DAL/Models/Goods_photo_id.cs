namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Goods_photo_id
    {
        [Key]
        [Column("Goods_photo_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Goods_photo_id1 { get; set; }

        [StringLength(150)]
        public string Goods_photo_path { get; set; }

        [StringLength(300)]
        public string Goods_photo_comments { get; set; }

        public int? Goods_id { get; set; }

        public int? Shop_id { get; set; }

        public virtual Shop_goods_list Shop_goods_list { get; set; }
    }
}
