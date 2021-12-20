using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntitFramework
{
    //katmanlar içerisindenkı sınıfıları haberleştrirerek 
    public class EFCategoryDal:GenericRepository<Category>,ICategoryDal
    {

    }
}
