namespace ProjectManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROJECTS")]
    public partial class PROJECT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROJECT()
        {
            PROJECT_TASKS = new HashSet<PROJECT_TASKS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal PROJECT_ID { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "NVARCHAR")]
        public string PROJECT_NAME { get; set; }

        [StringLength(1000)]
        [Column(TypeName = "NVARCHAR")]
        public string PROJECT_DESCRIPTION { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "NVARCHAR")]
        public string PROJECT_CLIENT { get; set; }

        [Column(TypeName = "date")]
        public DateTime PROJECT_BEGIN { get; set; }

        [Column(TypeName = "date")]
        public DateTime PROJECT_END { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PROJECT_STATUS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PROJECT_PAY_PER_HOUR { get; set; }

        public virtual PROJECT_STATUS PROJECT_STATUS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROJECT_TASKS> PROJECT_TASKS { get; set; }
    }
}
