using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntitFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
       
        CategoryManger cm = new CategoryManger(new EFCategoryDal());
        //listeleme işlemi yapacaz
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            //busines layerdeaki sınıfı çağıracaz
            var categoryvalues = cm.GetList();//üzerindeki // ları 29 videoda açtık
            return View(categoryvalues);
        }
        //   [HttpGet] //sayfa yüklendiği zaman devreye girer

        [HttpGet]
        public ActionResult AddCategory()
        { 
            return View();//sayfayıeri dondur
        }


        [HttpPost] // sayfada bir butona tıklandıgı zaman devreye girecel
        public ActionResult AddCategory(Category p)
        {
            //   cm.CategoryAddBL(p);

            CategoryValidator categoryValidator = new CategoryValidator();
            //31.videova. fluent validation result çağırmamız gerkıyur.using olarak
            ValidationResult result = categoryValidator.Validate(p);

            //eğer sonuc geçerliyse. Ekleme işlemi yaparken validationa gidiyor ve doğrulama alıyor.
            if (result.IsValid)
            {
                cm.CategoryAdd(p); //business leyerden geldi
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                //eğer sonuç gecerli değilse hata msjlarını oldğu yer olan validatore gidecek

                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(); //ekleme işlemi yapıldıktan sonra  GetCategoryList bu metoda git
        }

        //var silinecekPersonel = _personel.Where(p => p.Id == id).FirstOrDefault(); 
        //Personel listeme ait p adında gezici bir nesne oluştur ve bu nesne üzerinden tüm personellerimiz ID’lerini gez.Ne zaman ki Idsi benim parametre olarak aldığım idye eşit bir personel yakalarsın onu değişkene ata anlamında bir kod.
    }
}