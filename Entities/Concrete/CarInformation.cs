using Core.Entities.Abstract;
using Entities.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CarInformation : IEntity
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int BanId { get; set; }
        public Ban Ban { get; set; }
        public int MakeId { get; set; }
        public Make Make { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public int TransmissionId { get; set; }
        public Transmission Transmission { get; set; }
        public int ConditionId { get; set; }
        public Condition Condition { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public decimal Mileage { get; set; }
    }
}
