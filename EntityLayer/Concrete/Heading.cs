using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //public class oldu erişim kolay sağlansın diye
  public  class Heading
    {
        [Key]
        //bu sınıfa ait özellikler tanımlıyacaz
        public int HeadingID { get; set; } //bunlar veritabanına yansıyacak tablolar
        
        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }


        //ilişki bir e çok olacak
        //ilişki kuracakken ilişki olacak olan classdakki isimle
        //aynı olmak zorunda
        public int CategoryID { get; set; }
        //Category ile yapılan aynı işlem aslında alttaki
        public virtual Category Category { get; set; }


        //heading ile content ilişkilenece k
        public ICollection<Content> Contents { get; set; }

        public int WriterID { get; set; }
        //yazar bir tarafta başlıklar cok tarafında
        public virtual Writer Writer { get; set; }
    }
}
