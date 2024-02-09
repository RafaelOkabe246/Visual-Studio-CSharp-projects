using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStudy.Adapter
{
    internal class Adapter : ILanguage
    {
        private Alien alien;
        public Adapter(Alien _alien) 
        {
            alien = _alien;
        }

        public void SendMessage()
        {
            Console.Write("Tranlanting alien signnals: ");
            alien.SendSignals();
        }
    }
}
