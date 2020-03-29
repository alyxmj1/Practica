namespace WindowsFormsApp1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Пользователи> Пользователи { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Пользователи>()
                .Property(e => e.Логин)
                .IsFixedLength();

            modelBuilder.Entity<Пользователи>()
                .Property(e => e.Пароль)
                .IsFixedLength();
        }
    }
}
