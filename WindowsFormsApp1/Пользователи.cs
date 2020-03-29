namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Пользователи
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string Логин { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Пароль { get; set; }
    }
}
