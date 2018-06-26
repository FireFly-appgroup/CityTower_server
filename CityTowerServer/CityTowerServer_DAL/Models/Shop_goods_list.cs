namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shop_goods_list
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shop_goods_list()
        {
            Goods_photo_id = new HashSet<Goods_photo_id>();
        }

        [StringLength(300)]
        public string Goods_name { get; set; }

        [StringLength(300)]
        public string Goods_description { get; set; }

        public double? Goods_price { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Goods_id { get; set; }

        public int? Goods_category_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Shop_id { get; set; }

        public virtual Goods_category_list Goods_category_list { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Goods_photo_id> Goods_photo_id { get; set; }

        public virtual Shop Shop { get; set; }
    }
}
