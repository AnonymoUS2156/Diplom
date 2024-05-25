namespace Diploma
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AuthArchivist")]
    public partial class AuthArchivist
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Login { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Password { get; set; }
    }
}
