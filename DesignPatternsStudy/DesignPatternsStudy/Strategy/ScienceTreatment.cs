using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStudy.Strategy
{
    internal class ScienceTreatment : ITreatment
    {
        public string sideEffect = "A small fever";

        public void CurePatient(Patient patient)
        {
            Console.WriteLine("Some herbs are mixed with strange pills and then smashed and then dissolved in water.");
            patient.patientSideEffect = sideEffect;
            patient.SetIsSick(false);
        }

        public string SideEffectInfo()
        {
            return sideEffect;

        }
    }
}
