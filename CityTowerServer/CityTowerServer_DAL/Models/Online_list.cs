namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Online_list
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Uid { get; set; }

        public int Status_id { get; set; }

        public int User_guid { get; set; }

        public virtual Users Users { get; set; }

        public virtual Status_list Status_list { get; set; }
    }
}
