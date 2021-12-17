using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public interface IEntity
    {
    }

    public abstract class BaseEntity<TKey> : IEntity
    {
        public BaseEntity()
        {
            this.LastUpdateDate = DateTime.Now;
            this.CreateDate = DateTime.Now;

        }
        public TKey Id { get; set; }

        public bool IsDelete { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastUpdateDate { get; set; }
    }

    public abstract class BaseEntity : BaseEntity<int>
    {
      
    }
}
