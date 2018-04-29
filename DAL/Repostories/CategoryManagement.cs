using Model_Entity_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repostories
{
    //CRUD
    //CREATE
    //READ
    //UPDATE
    //DELETE
    public class CategoryManagement
    {
        NORTHWNDEntities db=new NORTHWNDEntities();

        public CategoryManagement()
        {
         //   db = new NORTHWNDEntities();
        }
        //create
         public void AddCategory(Category entity)
        {
            db.Categories.Add(entity);
            db.SaveChanges();
        }
        //read
         public Category GetByID(int entityID)
         {
             return db.Categories.Find(entityID);
         }

        public List<Category> ListCategories()
         {

             return db.Categories.ToList();
         }
   //update
        public void UpdateCategory(Category entity)
         {
             Category güncellenecekKategori = GetByID(entity.CategoryID);
             güncellenecekKategori.CategoryName = entity.CategoryName;
             güncellenecekKategori.Description = entity.Description;
             güncellenecekKategori.Picture = entity.Picture;
             db.SaveChanges();
         }

      
        //delete
        public void RemoveCategory(Category entity)
        {
            db.Categories.Remove(entity);
            db.SaveChanges();
        }
    }
}
