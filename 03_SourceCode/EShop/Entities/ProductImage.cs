namespace WebDemo.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductImage")]
    public partial class ProductImage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductImageID { get; set; }

        public int ProductID { get; set; }

        [Required]
        [StringLength(250)]
        public string Image { get; set; }

        public virtual Product Product { get; set; }
    }
}
