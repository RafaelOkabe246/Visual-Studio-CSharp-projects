using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStudy.Strategy
{
    internal class AlchemyTreatment : ITreatment
    {
        public string sideEffect = "Some mercury is inside your internal organs, but you should be fine";

        public void CurePatient(Patient patient)
        {
            Console.WriteLine("As the blood pounds from the cut on the right arm, a red metalic liquid is injected.");
            patient.patientSideEffect = sideEffect;
            patient.SetIsSick(false);
        }

        public string SideEffectInfo()
        {
            return sideEffect;
        }
    }
}
