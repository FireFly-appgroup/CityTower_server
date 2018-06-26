namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Blog_user_table
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Blog_id { get; set; }

        public int Uid { get; set; }

        public int Blog_status_id { get; set; }

        public virtual Blog_list Blog_list { get; set; }

        public virtual Blog_status_list Blog_status_list { get; set; }

        public virtual Users Users { get; set; }
    }
}
