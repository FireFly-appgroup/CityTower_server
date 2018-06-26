namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Blog_list
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Blog_id { get; set; }

        [Required]
        [StringLength(20)]
        public string Blog_status { get; set; }

        [Required]
        [StringLength(100)]
        public string Blog_name { get; set; }

        [StringLength(250)]
        public string Blog_slogon { get; set; }

        [StringLength(128)]
        public string Blog_avator { get; set; }

        public double? Blog_rating { get; set; }

        public int? Blog_like { get; set; }

        public int? Blog_dislike { get; set; }

        public int? Blog_subscribers_num { get; set; }

        public int Blog_category_id { get; set; }

        public virtual Blog_category_list Blog_category_list { get; set; }

        public virtual Blog_user_table Blog_user_table { get; set; }
    }
}
