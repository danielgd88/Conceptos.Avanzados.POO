using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public struct PropiedadesAnimal
    {
        private float PorcentajeGrasa;
        public float porcentajeGrasa
        {
            get
            {
                return this.PorcentajeGrasa;
            }
            set
            {
                if (value > -1 && value <= 100)
                    this.PorcentajeGrasa = value;
            }

        }

        private float PorcentajeAgua;
        public float porcentajeAgua
        {
            get
            {
                return this.PorcentajeAgua;
            }

            set
            {
                if (value > -1 && value <= 100)
                    this.PorcentajeAgua = value;
            }


        }



    }
}
