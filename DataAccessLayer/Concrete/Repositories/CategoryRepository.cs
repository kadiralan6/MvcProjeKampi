using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    //interfaceden miras aldık. categorydal tanımlayıncada alttakı metotlar geldi.
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
       DbSet<Category> _object;


        public void Delete(Category p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(Category p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Category> List()
        {
            return _object.ToList(); //tolist entityfrmwkde verileri listelemek için kullanılan metot
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }
    }
}

/* Entityde kullanılan
 ToList  Listeleme
Add  Ekleme
Remove Silme için
Find Bulma için 
 
 */