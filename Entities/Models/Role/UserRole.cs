using Entities.Models;
using Entities.Models.User;
using Entities.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class UserRole : BaseEntity
    {
        #region properties

        public int UserId { get; set; }

        public int RoleId { get; set; }

        #endregion

        #region Relations
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        [ForeignKey(nameof(RoleId))]
        public Role Role { get; set; }

        #endregion
    }
  

}
