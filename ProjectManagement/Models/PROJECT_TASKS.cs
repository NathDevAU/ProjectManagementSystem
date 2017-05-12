namespace ProjectManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROJECT_TASKS
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal TASK_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PROJECT_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EXPRET_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TASK_NAME { get; set; }

        [StringLength(400)]
        public string TASK_DESCRIPTION { get; set; }

        [StringLength(400)]
        public string TAS_DELIVERABLES { get; set; }

        [Column(TypeName = "date")]
        public DateTime TASK_BEGIN { get; set; }

        [Column(TypeName = "date")]
        public DateTime TASK_END { get; set; }

        [Required]
        [StringLength(1)]
        public string TASK_PRIORITY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TASK_STATUS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TASK_READY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TASK_HOURS { get; set; }

        public virtual EXPERT EXPERT { get; set; }

        public virtual PROJECT PROJECT { get; set; }

        public virtual TASK_STATUS TASK_STATUS1 { get; set; }
    }
}
