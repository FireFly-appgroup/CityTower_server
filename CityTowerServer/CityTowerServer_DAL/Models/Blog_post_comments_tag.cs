namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Blog_post_comments_tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Tag_id { get; set; }

        public int Blog_post_com_id { get; set; }

        public int Blog_id { get; set; }

        public virtual Tag_list Tag_list { get; set; }
    }
}
