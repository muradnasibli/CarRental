using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DomainModel
{
    public class Condition : IDomainEntity
    {
        public int Id { get; set; }
        public string CarCondition { get; set; }
    }
}
