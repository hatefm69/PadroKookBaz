using Common.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public interface IMyEntity
    {
    }


    public interface IEntity
    {
        public DateTime Create_Dm { get; set; }
        public string Create_Ds { get; set; }
        public DateTime? LastUpdate_Dm { get; set; }
        public string LastUpdate_Ds { get; set; }
    }

    public abstract class BaseEntity<TKey> : IEntity
    {
        public BaseEntity()
        {
            Create_Dm = DateTime.Now;
            Create_Ds = DateTime.Now.ToPersian();
        }
        public TKey Id { get; set; }
        public DateTime Create_Dm { get; set; }
        public string Create_Ds { get; set; }
        public DateTime? LastUpdate_Dm { get; set; }
        public string LastUpdate_Ds { get; set; }
    }

    public abstract class BaseEntity : BaseEntity<int>
    {
    }
}
