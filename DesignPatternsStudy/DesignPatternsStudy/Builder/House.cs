using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStudy.Builder
{
    internal class House
    {
        public EnvirommentType envirommentType { get; set; }
        public HouseShapeType houseShapeType { get; set; }

        public House(HouseBuilder _houseBuilder) 
        { 
            envirommentType = _houseBuilder.envirommentType;
            houseShapeType = _houseBuilder.houseShapeType;
        }
    }
}
