namespace WebDemo.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SubCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubCategory()
        {
            RelaChildSubCategories = new HashSet<RelaChildSubCategory>();
            RelaPriSubCategories = new HashSet<RelaPriSubCategory>();
        }

        [Key]
        public int SubCategoriesID { get; set; }

        [StringLength(50)]
        public string SubCateGoriesName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelaChildSubCategory> RelaChildSubCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelaPriSubCategory> RelaPriSubCategories { get; set; }
    }
}
