using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStudy.Strategy
{
    internal class Patient
    {
        public string? patientSideEffect;
        public bool isSick;



        public void SetIsSick(bool _isSick)
        {
            isSick = _isSick;
        }

        public void SetCollateralEffect(string _sideEffect)
        {
            patientSideEffect = _sideEffect;
        }

        public string GetSideEffect()
        {
            return patientSideEffect;
        }
    }
}
