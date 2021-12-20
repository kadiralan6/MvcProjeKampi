using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    //kodun açılımı: şart T:class olmali 
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object; //T değerine karşılık gelecek olan yapıyı nasıl bulacaz: constructer ile 

        //constructer oluştu. sınıfla aynı isim olmali
        //
        public GenericRepository() //ilk bu kod çalışr. 
        {
            _object = c.Set<T>(); //bu kod ile objectimiz artık entitiyden gelecek olan tablolardan biri olacak.
        }

        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }
        //video 37 de eklendi

        public T Get(Expression<Func<T, bool>> filter)
        {
            //singleor.. bir dizide veya listede sadece bir tane değer göndermek için yapılan linq kodu
            return _object.SingleOrDefault(filter);
           
        }

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }
}
