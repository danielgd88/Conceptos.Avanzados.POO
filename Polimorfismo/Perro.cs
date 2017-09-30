using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Perro: Animal
    {
        public Perro(int idAnimal, String nombreCientifico, DateTime horaRegistro)
        {
            this.idAnimal = idAnimal;
            this.nombreCientifico = nombreCientifico;
            this.horaRegistro = horaRegistro;
        }

        public override void sonido()
        {
            base.sonido();
            Console.WriteLine("Ladrando");
        }
    }
}
