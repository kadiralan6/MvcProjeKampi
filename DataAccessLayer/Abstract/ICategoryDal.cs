using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal:IRepository<Category>
    {
        //Crud
        //Type name(); metot tanımlarken

        //listelenecek olan entitiy yazılacak
        //alttakıler eski kod zor olan
        //List<Category> List(); //adı list 

        //void Insert(Category p);
         
        //void Update(Category p);
        //void Delete(Category p);


    }
}
