using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Gato : Animal
    {
        public Gato()
        {

        }


        public override void sonido()
        {
            base.sonido();
            Console.WriteLine("Maullando");
        }
    }
}
