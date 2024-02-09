using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStudy.Adapter
{
    internal class EarthSpeaker : ILanguage
    {
        public void SendMessage()
        {
            Console.WriteLine("Earth speaker");
        }
    }
}
