using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Roble : SerVivo
    {
        public Roble(int idSerVivo, String nombreCientifico, DateTime horaRegistro)
        {
            this.idSerVivo = idSerVivo;
            this.nombreCientifico = nombreCientifico;
            this.horaRegistro = horaRegistro;
        }
    }
}
