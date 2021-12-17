using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models.User
{
    public enum Provinces
    {
        [Display(Name = "تهران")]
        Tehran = 1,

        [Display(Name = "گیلان")]
        Gilan = 2,

        [Display(Name = "آذربایجان شرقی")]
        Azarbayejan_Sharghi = 3,

        [Display(Name = "خوزستان")]
        Khozestan = 4,

        [Display(Name = "فارس")]
        Fars = 5,

        [Display(Name = "اصفهان")]
        Esfahan = 6,

        [Display(Name = "خراسان رضوی")]
        Khorasan_Razavi = 7,

        [Display(Name = "قزوین")]
        Gazvin = 8,

        [Display(Name = "سمنان")]
        Semnana = 9,

        [Display(Name = "قم")]
        Gom = 10,

        [Display(Name = "مرکزی")]
        Markazi = 11,

        [Display(Name = "زنجان")]
        Zanjan = 12,

        [Display(Name = "مازندران")]
        Mazandaran = 13,

        [Display(Name = "گلستان")]
        Golestan = 14,

        [Display(Name = "اردبیل")]
        Ardabil = 15,

        [Display(Name = "آذربایجان غربی")]
        Azarbayejan_Garbi = 16,

        [Display(Name = "همدان")]
        Hamedan = 17,

        [Display(Name = "کردستان")]
        Kordestan = 18,

        [Display(Name = "کرمانشاه")]
        Kermanshah = 19,

        [Display(Name = "لرستان")]
        Lorestan = 20,

        [Display(Name = "بوشهر")]
        Boshehr = 21,

        [Display(Name = "کرمان")]
        Kerman = 22,

        [Display(Name = "هرمزگان")]
        Hormozgan = 23,

        [Display(Name = "چهارمحال و بختیاری")]
        ChaharMahal = 24,

        [Display(Name = "یزد")]
        Yazd = 25,

        [Display(Name = "سیستان و بلوچستان")]
        Sistan = 26,

        [Display(Name = "ایلام")]
        Ilam = 27,

        [Display(Name = "کهگلویه و بویراحمد")]
        Kohgilie = 28,

        [Display(Name = "خراسان شمالی")]
        Khorasan_Shomali = 29,

        [Display(Name = "خراسان جنوبی")]
        Khorasan_Jonobi = 30,

        [Display(Name = "البرز")]
        Alborz = 31,


    }
}
