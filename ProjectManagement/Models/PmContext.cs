namespace ProjectManagement
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Models;

    public partial class PmContext : DbContext
    {
        public PmContext()
            : base("name=PmContext")
        {
        }

        public virtual DbSet<EXPERT> EXPERTS { get; set; }
        public virtual DbSet<PROJECT_STATUS> PROJECT_STATUS { get; set; }
        public virtual DbSet<PROJECT_TASKS> PROJECT_TASKS { get; set; }
        public virtual DbSet<PROJECT> PROJECTS { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TASK_STATUS> TASK_STATUS { get; set; }
        public virtual DbSet<CLIENT> CLIENT { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EXPERT>()
                .Property(e => e.EXPRET_ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EXPERT>()
                .Property(e => e.EXPERT_TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EXPERT>()
                .Property(e => e.EXPERT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<EXPERT>()
                .Property(e => e.EXPERT_SURNAME)
                .IsUnicode(false);

            modelBuilder.Entity<EXPERT>()
                .Property(e => e.EXPERT_LASTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<EXPERT>()
                .HasMany(e => e.PROJECT_TASKS)
                .WithRequired(e => e.EXPERT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROJECT_STATUS>()
                .Property(e => e.PSTATUS_ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PROJECT_STATUS>()
                .Property(e => e.PSTATUS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PROJECT_STATUS>()
                .HasMany(e => e.PROJECTS)
                .WithRequired(e => e.PROJECT_STATUS1)
                .HasForeignKey(e => e.PROJECT_STATUS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROJECT_TASKS>()
                .Property(e => e.TASK_ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PROJECT_TASKS>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PROJECT_TASKS>()
                .Property(e => e.EXPRET_ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PROJECT_TASKS>()
                .Property(e => e.TASK_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PROJECT_TASKS>()
                .Property(e => e.TASK_DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<PROJECT_TASKS>()
                .Property(e => e.TAS_DELIVERABLES)
                .IsUnicode(false);

            modelBuilder.Entity<PROJECT_TASKS>()
                .Property(e => e.TASK_PRIORITY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PROJECT_TASKS>()
                .Property(e => e.TASK_STATUS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PROJECT_TASKS>()
                .Property(e => e.TASK_READY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PROJECT_TASKS>()
                .Property(e => e.TASK_HOURS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PROJECT>()
                .Property(e => e.PROJECT_ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PROJECT>()
                .Property(e => e.PROJECT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PROJECT>()
                .Property(e => e.PROJECT_DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<PROJECT>()
                .Property(e => e.PROJECT_STATUS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PROJECT>()
                .Property(e => e.PROJECT_PAY_PER_HOUR)
                .HasPrecision(10, 2);

            modelBuilder.Entity<PROJECT>()
                .HasMany(e => e.PROJECT_TASKS)
                .WithRequired(e => e.PROJECT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TASK_STATUS>()
                .Property(e => e.STATUS_ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TASK_STATUS>()
                .Property(e => e.STATUS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<TASK_STATUS>()
                .HasMany(e => e.PROJECT_TASKS)
                .WithRequired(e => e.TASK_STATUS1)
                .HasForeignKey(e => e.TASK_STATUS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENT>()
            .Property(e => e.CLIENT_ID)
            .HasPrecision(18, 0);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.CLIENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .HasMany(e => e.PROJECTS)
                .WithRequired(e => e.CLIENT)
                .HasForeignKey(e => e.CLIENT_ID)
                .WillCascadeOnDelete(false);
        }
    }
}
