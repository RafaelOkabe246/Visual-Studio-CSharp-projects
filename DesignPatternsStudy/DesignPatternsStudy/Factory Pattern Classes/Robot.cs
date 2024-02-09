using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStudy.Factory_Pattern_Classes
{
    public abstract class Robot
    {
        protected string OriginFactory;
        protected int firePower;
        protected int speed;
        protected int armor;

        public Robot(RobotFactory _producer) 
        { 
            OriginFactory = _producer.factoryName;
        }

        public string GetProducerRegister()
        {
            return $"This robot  was mande in " + OriginFactory;
        }


        public abstract void Build();

    }
}
