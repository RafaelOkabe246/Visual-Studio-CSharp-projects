
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStudy.Factory_Pattern_Classes
{
    public abstract class RobotFactory
    {

        public string factoryName { get; private set; }
        public string factoryId {  get; private set; }
            
        public RobotFactory(string _id, string _factoryName) 
        { 
            factoryName = _factoryName;
            factoryId = _id;
        }


        public Robot OrderRobot()
        {
            Robot robot = CreateRobot();
            robot.Build();
            return robot; 
        }

        public abstract Robot CreateRobot();
    }
}
