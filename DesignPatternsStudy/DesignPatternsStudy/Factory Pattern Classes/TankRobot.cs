using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStudy.Factory_Pattern_Classes
{
    internal class TankRobot : Robot
    {
        public TankRobot(RobotFactory _producer) : base(_producer)
        {
        }

        public override void Build()
        {
            throw new NotImplementedException();
        }

    }
}
