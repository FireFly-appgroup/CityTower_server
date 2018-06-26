namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_settings
    {
        [MaxLength(1)]
        public byte[] User_settings_gps { get; set; }

        public int? User_settings_skin_id { get; set; }

        public int? User_settings_language_id { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Uid { get; set; }

        public virtual Language_list Language_list { get; set; }

        public virtual Skin_list Skin_list { get; set; }

        public virtual Users Users { get; set; }
    }
}
