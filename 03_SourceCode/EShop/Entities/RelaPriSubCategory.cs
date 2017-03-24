namespace WebDemo.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RelaPriSubCategory
    {
        [Key]
        public int DetailCategoriesID { get; set; }

        public int PriCategoriesID { get; set; }

        public int SubCategoriesID { get; set; }

        public virtual PriCategory PriCategory { get; set; }

        public virtual SubCategory SubCategory { get; set; }
    }
}
