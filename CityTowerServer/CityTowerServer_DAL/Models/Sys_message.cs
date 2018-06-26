namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Uid { get; set; }

        [Column("Sys_message")]
        [StringLength(200)]
        public string Sys_message1 { get; set; }

        public DateTime? Sys_message_date { get; set; }

        public virtual Users Users { get; set; }
    }
}
