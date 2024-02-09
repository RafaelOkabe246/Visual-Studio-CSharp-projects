using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStudy.Builder
{
    internal class HouseBuilder
    {
        public EnvirommentType envirommentType { get; set; }
        public HouseShapeType houseShapeType { get; set; }

        public HouseBuilder() 
        {
            this.houseShapeType = new HouseShapeType();
            this.envirommentType = new EnvirommentType();
        }

        public HouseBuilder SetEnvirommentType(EnvirommentType newEnvirommentType)
        {
            this.envirommentType = newEnvirommentType;
            return this;
        }
        public HouseBuilder SetHouseShapeType(HouseShapeType newHouseShapeType)
        {
            this.houseShapeType = newHouseShapeType;
            return this;
        }

        public House BuildHouse()
        {
            return new House(this);
        }
    }
}
