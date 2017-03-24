namespace WebDemo.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RelaChildSubCategory
    {
        [Key]
        public int RelaChildSubID { get; set; }

        public int SubCategoriesID { get; set; }

        public int ChildCategoriesID { get; set; }

        public virtual ChildCategory ChildCategory { get; set; }

        public virtual SubCategory SubCategory { get; set; }
    }
}
