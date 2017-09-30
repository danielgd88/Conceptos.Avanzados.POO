using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
  public abstract class Animal
    {
        protected int idAnimal { get; set; }
        protected String nombreCientifico { get; set; }
        protected DateTime horaRegistro { get; set; }

        public abstract void sonido();

      
       // public abstract override string ToString();

    }
}
