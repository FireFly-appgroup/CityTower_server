namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            All_chat = new HashSet<All_chat>();
            Announcement = new HashSet<Announcement>();
            Auctioneer = new HashSet<Auctioneer>();
            Blog_user_table = new HashSet<Blog_user_table>();
            Like_dislike_list = new HashSet<Like_dislike_list>();
            News = new HashSet<News>();
            Places = new HashSet<Places>();
            Poster = new HashSet<Poster>();
            Shop = new HashSet<Shop>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Uid { get; set; }

        [MaxLength(1)]
        public byte[] User_premium_status { get; set; }

        public DateTime User_reg_date { get; set; }

        [Required]
        [StringLength(50)]
        public string User_name { get; set; }

        [Required]
        [StringLength(100)]
        public string User_firstname { get; set; }

        [Required]
        [StringLength(100)]
        public string User_lastname { get; set; }

        [Required]
        [StringLength(20)]
        public string User_tel { get; set; }

        [Required]
        [StringLength(100)]
        public string User_nikname { get; set; }

        public DateTime? User_date_of_birth { get; set; }

        [Required]
        [StringLength(100)]
        public string User_password { get; set; }

        [Required]
        [StringLength(100)]
        public string User_email { get; set; }

        [StringLength(100)]
        public string User_avator { get; set; }

        public double? User_rating { get; set; }

        public int? User_like { get; set; }

        public int? User_dislike { get; set; }

        [Column(TypeName = "xml")]
        public string User_password_history { get; set; }

        [Column(TypeName = "xml")]
        public string User_log_file { get; set; }

        [StringLength(20)]
        public string User_location { get; set; }

        public DateTime? User_last_online { get; set; }

        [StringLength(300)]
        public string User_slogon { get; set; }

        public int? Sex_id { get; set; }

        public int City_id { get; set; }

        public int Country_id { get; set; }

        public int? User_bonus_count { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<All_chat> All_chat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Announcement> Announcement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Auctioneer> Auctioneer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Blog_user_table> Blog_user_table { get; set; }

        public virtual City_list City_list { get; set; }

        public virtual Country_list Country_list { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Like_dislike_list> Like_dislike_list { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<News> News { get; set; }

        public virtual Online_list Online_list { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Places> Places { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Poster> Poster { get; set; }

        public virtual Sex_list Sex_list { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop> Shop { get; set; }

        public virtual Sys_message Sys_message { get; set; }

        public virtual User_settings User_settings { get; set; }
    }
}
