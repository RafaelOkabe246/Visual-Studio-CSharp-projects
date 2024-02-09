using System;
using System.Collections.Generic;
using System.Text;

namespace _4_SEMESTRE_ADO_1
{
    class Retangulo
    {
        public float altura;
        public float largura;

        public Retangulo(float _altura, float _largura)
        {
            this.altura = _altura;
            this.largura = _largura;
        }

        public float CalcularArea()
        {
            float area = altura * largura;
            return area;
        }
    }
}
