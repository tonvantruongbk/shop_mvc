using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebDemo.Entities;

namespace WebDemo.Models
{
    public class HomeModel
    {
       
        public List<Manufactory> LstManufactoriesItem { get; set; }
        public List<Category> LstCategories { get; set; }
      

        public HomeModel()
        {
            getCategories();
            getManufactories();
        }

        DBConnect dbconnect = new DBConnect();

        public void getCategories()
        {
            LstCategories = new List<Category>();

            foreach (var item in dbconnect.Categories.ToList())
            {
                Category cat = new Category();
                cat.ID = item.ID;
                cat.CategoriesName = item.CategoriesName;
                cat.CategoriesImages = item.CategoriesImages;
                cat.CategoriesParentID = item.CategoriesParentID;
                LstCategories.Add(cat);
            }
        }

       
        public void getManufactories()
        {
            LstManufactoriesItem = new List<Manufactory>();
           
                foreach(var item in dbconnect.Manufactories.ToList())
                {
                    Manufactory cat = new Manufactory();
                    cat.ManufactoriesID = item.ManufactoriesID;
                    cat.ManufactoriesName = item.ManufactoriesName;
                    cat.ImageIcon = item.ImageIcon;
                    LstManufactoriesItem.Add(cat);
                }
           
        }



    }
}