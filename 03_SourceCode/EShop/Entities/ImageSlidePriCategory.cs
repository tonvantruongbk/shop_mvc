namespace WebDemo.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ImageSlidePriCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ImageSlidePriCategoriesID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PriCategoriesID { get; set; }

        [Required]
        [StringLength(250)]
        public string Image { get; set; }

        public virtual PriCategory PriCategory { get; set; }
    }
}
