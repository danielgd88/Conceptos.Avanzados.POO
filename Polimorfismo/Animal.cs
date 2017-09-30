using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Animal
    {
        protected int idAnimal { get; set; }
        protected String nombreCientifico { get; set; }
        protected DateTime horaRegistro { get; set; }

        public Animal()
        {
            
        }

        public virtual void sonido()
        {
            Console.WriteLine("El animal esta: ");
        }
    }
}
