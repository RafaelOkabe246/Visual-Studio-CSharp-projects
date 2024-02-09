using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStudy.Strategy
{
    internal interface ITreatment
    {
        public void CurePatient(Patient patient);

        public string SideEffectInfo();
    }
}
