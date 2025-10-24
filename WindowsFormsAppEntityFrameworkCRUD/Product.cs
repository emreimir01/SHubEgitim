namespace WindowsFormsAppEntityFrameworkCRUD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreateDate { get; set; }

        public int Stock { get; set; }

        public decimal Price { get; set; }
        // �r�n ve kategori aras�nda ili�ki kurulmas�
        public int? CategoryId { get; set; } // �r�n�n kategori bilgisini tutacak
        public virtual Category Category { get; set; } // Navigation property
    }
}
