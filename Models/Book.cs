namespace Diploma.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            Employee = new HashSet<Employee>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? AuthorID { get; set; }

        public int? PublisherID { get; set; }

        public int? Year { get; set; }

        public int? Pages { get; set; }

        [StringLength(13)]
        public string ISBN { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }


        [StringLength(6)]
        public string Author_Sign { get; set; }

        public int? Disciplines { get; set; }

        [StringLength(20)]
        public string Photo { get; set; }

        public virtual Author Author { get; set; }

        public virtual Disciplines Disciplines1 { get; set; }

        public virtual Publisher Publisher { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employee { get; set; }
    }
}
