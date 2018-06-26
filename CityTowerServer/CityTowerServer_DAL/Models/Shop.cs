namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shop")]
    public partial class Shop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shop()
        {
            Comments_eshop = new HashSet<Comments_eshop>();
            Shop_goods_list = new HashSet<Shop_goods_list>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Shop_id { get; set; }

        [Required]
        [StringLength(150)]
        public string Shop_name { get; set; }

        [Required]
        [StringLength(300)]
        public string Shop_comments { get; set; }

        [StringLength(1000)]
        public string Shop_slogon { get; set; }

        public double? Shop_rating { get; set; }

        public int? Shop_like { get; set; }

        public int? Shop_dislike { get; set; }

        public DateTime Shop_reg_date { get; set; }

        public int? Uid { get; set; }

        public int? City_id { get; set; }

        public int? Country_id { get; set; }

        public virtual City_list City_list { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comments_eshop> Comments_eshop { get; set; }

        public virtual Country_list Country_list { get; set; }

        public virtual Users Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_goods_list> Shop_goods_list { get; set; }
    }
}
