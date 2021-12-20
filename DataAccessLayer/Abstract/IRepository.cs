using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{

   public interface IRepository<T>
    {
        //biz bu yapıyla şunun önüne geçtik.
        //Bizdeki category,heading tabloları için hepsine ayrı ayrı Abstract içerisenide IcategoryDal,Iwriter yazmaktansa tek bir metot ile hepsine ulaşmiş olacağiz.
        List<T> List();
        void Insert(T p);
        void Delete(T p);
        //Id sini çağıracak olursak bunu yazmamız lazım 37.video
        T Get(Expression<Func<T, bool>> filter);
        void Update(T p);
        //şartlı listeleme mesela sadece adı ali olanlar gelecek
        List<T> List(Expression<Func<T, bool>> filter);
    }
}
