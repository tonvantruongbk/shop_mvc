namespace WebDemo.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PriCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PriCategory()
        {
            ImageSlidePriCategories = new HashSet<ImageSlidePriCategory>();
            RelaPriSubCategories = new HashSet<RelaPriSubCategory>();
        }

        [Key]
        public int PriCategoriesID { get; set; }

        [Required]
        [StringLength(50)]
        public string PriCategoriesName { get; set; }

        [Required]
        [StringLength(50)]
        public string PriCategoriesImages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImageSlidePriCategory> ImageSlidePriCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelaPriSubCategory> RelaPriSubCategories { get; set; }
    }
}
