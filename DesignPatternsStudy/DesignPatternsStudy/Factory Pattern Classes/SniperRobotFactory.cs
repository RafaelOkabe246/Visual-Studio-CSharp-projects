﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStudy.Factory_Pattern_Classes
{
    internal class SniperRobotFactory : RobotFactory
    {
        public SniperRobotFactory(string _id, string _producerName) : base(_id, _producerName)
        {
        }

        public override Robot CreateRobot()
        {
            return new SniperRobot(this);
        }
    }
}
