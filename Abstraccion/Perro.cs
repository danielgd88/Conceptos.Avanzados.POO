using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public class Perro : Animal
    {

        public Perro(int idAnimal, String nombreCientifico, DateTime horaRegistro)
        {
            base.idAnimal = idAnimal;
            base.nombreCientifico = nombreCientifico;
            base.horaRegistro = horaRegistro;

        }

        public override void sonido()
        {
            Console.WriteLine("Ladrido...");
        }

        
    }
}
