namespace WebDemo.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Manufactory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ManufactoriesID { get; set; }

        [StringLength(50)]
        public string ManufactoriesName { get; set; }

        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
