using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace _16_MVC_Validation.ValidationClasses
{
    public class MailValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            string kontrolEdilecekVeri;
            if (value == null) // null ise geçersizdir.
            return false;
            kontrolEdilecekVeri = value.ToString();
            if(kontrolEdilecekVeri.Where(k=>k==' ').ToList().Count() > 0 )
                return false;

            if(kontrolEdilecekVeri .Split('@').Count() > 2 )
                return false;
            if(kontrolEdilecekVeri.EndsWith("@bilgeadam.com"))
                return false;
            return false;
           
        }
    }
}
