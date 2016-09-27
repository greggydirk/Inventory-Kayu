using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudyCaseRPl.Models;

namespace StudyCaseRPl.DAL
{
    public class AuthorDAL
    {
        private SampleShopDBEntities db;
        public AuthorDAL()
        {
            db = new SampleShopDBEntities();
        }
        //Menampilkan semua data author
        public IQueryable<Author> GetAll()
        {
            var result = from c in db.Authors
                         orderby c.FisrtName ascending
                         select c;

            return result;
        }
        public Author GetById(int id)
        {
            var result = (from c in db.Authors
                          where c.AuthorID == id
                          select c).FirstOrDefault();
            if (result != null)
                return result;
            else
                throw new Exception("Data dengan id" + id.ToString() + "TIdak  Ditemukan");
        }
    }
}