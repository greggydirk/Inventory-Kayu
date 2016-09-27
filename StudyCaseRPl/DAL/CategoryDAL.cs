using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudyCaseRPl.Models;
namespace StudyCaseRPl.DAL
{
    public class CategoryDAL
    {
        private SampleShopDBEntities db;
        public CategoryDAL()
        {
            db = new SampleShopDBEntities();
        }
        //menampilkan semua data category
        public IQueryable<Category> GetAll()
        {
            var result = from c in db.Categories
                         orderby c.CategoryName ascending
                         select c;

            return result;
        }
        public Category GetById(int id)
        {
            var result = (from c in db.Categories
                         where c.CategoryID == id
                         select c).FirstOrDefault();

            if (result != null)
                return result;
            else
                throw new Exception("Data dengan id" + id.ToString() + "Tidak ditemukan");
        }
    }
}