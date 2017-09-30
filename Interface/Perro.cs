using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Perro : SerVivo, ISonido
    {
        public Perro(int idSerVivo, String nombreCientifico, DateTime horaRegistro)
        {
            this.idSerVivo = idSerVivo;
            this.nombreCientifico = nombreCientifico;
            this.horaRegistro = horaRegistro;
        }

        public void sonido()
        {
            Console.WriteLine("Ladrido");
        }
    }
}
