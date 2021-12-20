using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    //service almayı ders 28 de aldık.
    public class CategoryManger : ICategoryService
    {

        //alttaki kod iptal oldu ders27 de
        //bunları artıl cateforyservive üzerinden çağıracağız
        //   GenericRepository<Category> repo = new GenericRepository<Category>();
        //her bir işlem için metot tanımlayacaz


        /* public List<Category> GetAllBL()
         {
             return repo.List(); //biz listeleme yaptık
         }
         public void CategoryAddBL(Category p)
         {
             if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName.Length >= 51)
             {
                 /// Hata MEsaji


             }
             else
             {
                 repo.Insert(p);
             }
         }*/
        //biz üstteki kategori  yapmamamiz gerekiyor onu 30.derste validator ile öğrendik 


        ICategoryDal _categoryDal; //buna bir atama yapacaz bunun içinde constructer oluşturacaz

        public CategoryManger(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

       

        //
        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }
        //video 38. servicde yazdık once
        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);         
        }
        //video 39
        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        //37.video video sonu
        public Category GetByID(int id)
        {
            return _categoryDal.Get(x => x.CategoryID == id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }
    }
}
