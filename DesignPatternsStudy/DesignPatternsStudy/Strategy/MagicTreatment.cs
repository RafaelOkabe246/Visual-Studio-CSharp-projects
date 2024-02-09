using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStudy.Strategy
{
    internal class MagicTreatment : ITreatment
    {
        public string sideEffect = "Mana energy particles in the blood";

        public void CurePatient(Patient patient)
        {
            Console.WriteLine("A giant mushroom is growing on the torax of the patient.");
            patient.patientSideEffect = sideEffect;
            patient.SetIsSick(false);
        }

        public string SideEffectInfo()
        {
            return sideEffect;
        }
    }
}
