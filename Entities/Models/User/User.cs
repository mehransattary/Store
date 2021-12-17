using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entities.Models.User
{
    public class User:BaseEntity
    {
        #region common
        //***====================================================================================***//
        [Display(Name = "تصویر")]
        [MaxLength(150, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string User_Image { get; set; }
        //***====================================================================================***//
        [Display(Name = "ایمیل")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string User_Email { get; set; }
        //***====================================================================================***//
        [Display(Name = "کلمه عبور")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string User_Password { get; set; }
        //***====================================================================================***//
        [Display(Name = "  کلمه عبور یکبارمصرف")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string User_Password_Disposable { get; set; }
        //***====================================================================================***//
        [Display(Name = "نام")]

        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string User_FirstName { get; set; }
        //***====================================================================================***//
        [Display(Name = "نام خانوادگی")]

        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string User_LastName { get; set; }


        //***====================================================================================***//
        [DataType(DataType.MultilineText)]
        [Display(Name = "آدرس")]
        [MaxLength(500, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string User_Address { get; set; }
        //***====================================================================================***//
        [MaxLength(50, ErrorMessage = "نباید بیشتر از{1}کاراکتر وارد شه")]
        [Display(Name = "شماره همراه")]
        [RegularExpression(@"^\(?((\+98|0)?9\d{9})$", ErrorMessage = "لطفا شماره موبایل صحیح را وارد نمایید .")]
        public string User_Mobile { get; set; }
        //***====================================================================================***//
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string User_EmailActiveCode { get; set; }
        //***====================================================================================***//

        public bool User_IsActivated { get; set; }
        //***====================================================================================***//
        public DateTimeOffset? User_LastLoginDate { get; set; }
        //***====================================================================================***//
        [Display(Name = "کدمنحصربه فرد")]
        public string User_CodeActivate { get; set; }
        //***====================================================================================***//
        public bool IsAdmin { get; set; }
        //***====================================================================================***//
        public Role_Permission Role_number { get; set; }//
         //***====================================================================================***//

        //public Guid SecurityStamp { get; set; }
        #endregion
        #region Buyer
        public BuyerEnum BuyerType { get; set; }

        //***====================================================================================***//
        [DataType(DataType.PostalCode)]
        [Display(Name = "کد پستی")]
        [MaxLength(50, ErrorMessage = "نباید بیشتر از {1} کاراکتر وارد شه")]
        public string User_PostalCode { get; set; }
        //***====================================================================================***//    
        [Display(Name = "شهر ")]
        public string User_Cityname { get; set; }
        //***====================================================================================***//
        [Display(Name = "استان ")]
        public Provinces User_Provinces { get; set; }
        //***====================================================================================***//
        [Display(Name = "جنسیت ")]
        public GenderType User_Gender { get; set; }

        //***====================================================================================***//
        #endregion

    }
}
