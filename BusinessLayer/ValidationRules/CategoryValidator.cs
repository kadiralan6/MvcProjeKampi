﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    //fluentvalidation paketini nugetten kurmak gerekiyo
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            //rulefor doğrulama kuralları. 
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage(" Kategori adini Boş geçemezsiniz.");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla değer girişi yapmayın");
        }
    }
}
