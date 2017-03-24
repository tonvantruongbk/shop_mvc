namespace WebDemo.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductFollowAge")]
    public partial class ProductFollowAge
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductAgeID { get; set; }

        public int? ProductID { get; set; }

        [StringLength(50)]
        public string Age { get; set; }

        public virtual Product Product { get; set; }
    }
}
