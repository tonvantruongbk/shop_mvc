namespace WebDemo.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ImageSlideCategory
    {
        [Key]
        public int ImageSlideCategoriesID { get; set; }

        public int CategoriesID { get; set; }

        [Required]
        [StringLength(250)]
        public string Image { get; set; }

        public virtual Category Category { get; set; }
    }
}
