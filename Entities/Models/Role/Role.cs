using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Roles
{
    public class Role : BaseEntity
    {
        #region Properties

        [Display(Name = "نام سیستمی ")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string Role_Name { get; set; }

        [Display(Name = "عنوان ")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string Role_Title { get; set; }

        #endregion

        #region Relations

        public ICollection<UserRole> UserRoles { get; set; }

        #endregion
    }
    //public class Configuration_Role : IEntityTypeConfiguration<Role>
    //{
    //    public void Configure(EntityTypeBuilder<Role> builder)
    //    {
    //        builder.HasQueryFilter(x => !x.IsDelete);

    //    }
    //}

}
