using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CarInformation : IEntity
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public int BanId { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public int ColorId { get; set; }
        public int TransmissionId { get; set; }
        public int ConditionId { get; set; }
        public int ImageId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public decimal Mileage { get; set; }
    }
}
