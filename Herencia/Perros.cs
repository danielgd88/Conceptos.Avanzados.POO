using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
   public class Perros : Animal
    {



        public Perros(string nombreCientifico, Genero genero, PropiedadesAnimal propPiedadesPerro)
        {

            this.nombreCientifico = nombreCientifico;
            this.generoAnimal = genero;
            this.propiedadesAnimal = propPiedadesPerro;

        }


        
    }
}
