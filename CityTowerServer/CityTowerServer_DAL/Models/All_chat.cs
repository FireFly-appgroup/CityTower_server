namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class All_chat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int All_chat_mess_id { get; set; }

        [Required]
        [StringLength(300)]
        public string All_chat_mess_body { get; set; }

        public DateTime All_chat_mess_date { get; set; }

        public int Uid { get; set; }

        public int City_id { get; set; }

        public int? Room_id { get; set; }

        public virtual Users Users { get; set; }

        public virtual City_list City_list { get; set; }

        public virtual Room_chat_id Room_chat_id { get; set; }
    }
}
