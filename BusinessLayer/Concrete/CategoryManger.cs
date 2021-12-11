using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
  public  class CategoryManger 
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();
        //her bir işlem için metot tanımlayacaz
        public List<Category> GetAllBL()
        {
            return repo.List(); //biz listeleme yaptık
        }
        public void CategoryAddBL(Category p)
        {
            if (p.CategoryName=="" || p.CategoryName.Length<=3 || p.CategoryDescription=="" || p.CategoryName.Length>=51)
            {
                /// Hata MEsaji

            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
