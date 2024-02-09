using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStudy.Facade
{
    internal class Settings
    {
        public bool limitedLight;
        public bool immortalEnemies;

        public void SetLimitedLight(bool limitedLight)
        {
            this.limitedLight = limitedLight;
        }

        public void SetImmortalEnemies(bool immortalEnemies)
        {
            this.immortalEnemies = immortalEnemies;
        }
    }
}
