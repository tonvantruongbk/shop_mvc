using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebDemo.Entities;

namespace WebDemo.Models
{
    public class HomeModel
    {
        public List<PriCategory> LstCatergoriesItem { get; set; }
        public List<SubCategory> LstSubCategoriesItem { get; set; }
        public List<ChildCategory> LstChildCategoriesItem { get; set; }
        public List<RelaPriSubCategory> LstRelaPriSubCategory { get; set; }
        public List<RelaChildSubCategory> LstRelaChildSubCategory { get; set; }
        public class LstChildCate
        {
            public int SubID { get; set; }
            public int ChildID { get; set; }
        }
        public List<LstChildCate> LstChildCategories { get; set; }
        DBConnect dbconnect = new DBConnect();
        public HomeModel() {
            getCategories();
            getSubCategories();
            getChildCategories();
            getRelaPriSubCategories();
            getRelaChildSubCategories();
            getLstChildCate();
        }
        public void getCategories() {
            LstCatergoriesItem = new List<PriCategory>();

            try
            {
                foreach (var item in dbconnect.PriCategories.ToList()){

                    PriCategory cat = new PriCategory();
                    cat.PriCategoriesID = item.PriCategoriesID;
                    cat.PriCategoriesImages = item.PriCategoriesImages;
                    cat.PriCategoriesName = item.PriCategoriesName;
                    LstCatergoriesItem.Add(cat);
               
                 }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void getSubCategories() {
            LstSubCategoriesItem = new List<SubCategory>();

            try
            {
                foreach (var item in dbconnect.SubCategories.ToList())
                {

                    SubCategory cat = new SubCategory();
                    cat.SubCategoriesID = item.SubCategoriesID;
                    cat.SubCateGoriesName = item.SubCateGoriesName;

                    LstSubCategoriesItem.Add(cat);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void getChildCategories()
        {
            LstChildCategoriesItem = new List<ChildCategory>();

            try
            {
                foreach (var item in dbconnect.ChildCategories.ToList())
                {

                    ChildCategory cat = new ChildCategory();
                    cat.ChildCategoriesID = item.ChildCategoriesID;
                    cat.ChildCategoriesName= item.ChildCategoriesName;

                    LstChildCategoriesItem.Add(cat);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void getRelaPriSubCategories()
        {
            LstRelaPriSubCategory = new List<RelaPriSubCategory>();

            try
            {
                foreach (var item in dbconnect.RelaPriSubCategories.ToList())
                {

                    RelaPriSubCategory cat = new RelaPriSubCategory();
                    cat.DetailCategoriesID = item.DetailCategoriesID;
                    cat.PriCategoriesID = item.PriCategoriesID;
                    cat.SubCategoriesID = item.SubCategoriesID;

                    LstRelaPriSubCategory.Add(cat);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void getRelaChildSubCategories()
        {
            LstRelaChildSubCategory = new List<RelaChildSubCategory>();

            try
            {
                foreach (var item in dbconnect.RelaChildSubCategories.ToList())
                {

                    RelaChildSubCategory cat = new RelaChildSubCategory();
                    cat.ChildCategoriesID = item.ChildCategoriesID;
                    cat.SubCategoriesID = item.SubCategoriesID;
                    LstRelaChildSubCategory.Add(cat);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void getLstChildCate()
        {
            getChildCategories();
            LstChildCategories = new List<LstChildCate>();

            foreach (var item in LstChildCategoriesItem)
            {
                LstChildCate cat = new LstChildCate();
                cat.ChildID = item.ChildCategoriesID;
                LstChildCategories.Add(cat);
                LstChildCategories.Distinct();
            }
        }

    }
}