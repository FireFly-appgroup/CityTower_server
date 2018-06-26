namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Blog_post_comments
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Blog_post_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Blog_post_com_id { get; set; }

        public int Uid { get; set; }

        public DateTime Blog_post_com_data { get; set; }

        [Required]
        [StringLength(3800)]
        public string Blog_post_com_body { get; set; }

        public int? Blog_post_com_like { get; set; }

        public int? Blog_post_com_dislike { get; set; }

        public virtual Blog_post_table Blog_post_table { get; set; }
    }
}
