using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DomainModel
{
    public class Model : BaseDomainModel, IDomainEntity
    {
        public int MakeId { get; set; }
    }
}
