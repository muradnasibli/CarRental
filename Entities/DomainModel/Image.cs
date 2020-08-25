using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DomainModel
{
    public class Image : IEntity
    {
        public int Id { get; set; }
        public string FirstImagePath { get; set; }
        public string SecondImagePath { get; set; }
        public string ThirdImagePath { get; set; }
        public string FourthImagePath { get; set; }
        public string FifthImagePath { get; set; }
        public string SixthImagePath { get; set; }
    }
}
