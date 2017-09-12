using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herencia;

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal p = new Perros("Perrus Caninus", Genero.Femenino, new PropiedadesAnimal()
            {
                porcentajeAgua = 10,
                porcentajeGrasa = 90
            });



          
            Console.WriteLine(p.ToString());
            Console.ReadKey();
        }
    }
}
