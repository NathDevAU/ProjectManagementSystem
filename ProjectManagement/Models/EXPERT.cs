namespace ProjectManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EXPERTS")]
    public partial class EXPERT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EXPERT()
        {
            PROJECT_TASKS = new HashSet<PROJECT_TASKS>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal EXPRET_ID { get; set; }

        [Required]
        [StringLength(1)]
        [Column(TypeName = "NVARCHAR")]
        public string EXPERT_TYPE { get; set; }

        [StringLength(50)]
        [Column(TypeName = "NVARCHAR")]
        public string EXPERT_NAME { get; set; }

        [StringLength(50)]
        [Column(TypeName = "NVARCHAR")]
        public string EXPERT_SURNAME { get; set; }

        [StringLength(50)]
        [Column(TypeName = "NVARCHAR")]
        public string EXPERT_LASTNAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROJECT_TASKS> PROJECT_TASKS { get; set; }
    }
}
