namespace WebDemo.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ImageManufactory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ImageManufactoriesID { get; set; }

        public int ManufactoriesID { get; set; }

        [Required]
        [StringLength(250)]
        public string Image { get; set; }
    }
}
