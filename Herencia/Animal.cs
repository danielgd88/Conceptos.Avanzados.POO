using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
   public class Animal
    {
        protected int idAnimal { get; set; }
        protected String nombreCientifico { get; set; }
        protected DateTime horaRegistro { get; set; }


        protected Genero generoAnimal { get; set; }
        protected PropiedadesAnimal propiedadesAnimal { get; set; }


        public virtual void sonido()
        {

        }

        public override string ToString()
        {
            return "Nombre cientifico: " + nombreCientifico + Environment.NewLine +
                   "Hora de registro: " + horaRegistro.ToShortDateString() + Environment.NewLine +
                   "========================================================================" +
                   "========================================================================" +
                   "% Agua: " + this.propiedadesAnimal.porcentajeAgua + Environment.NewLine +
                   "% Grasa: " + this.propiedadesAnimal.porcentajeGrasa;
        }

    }

}
