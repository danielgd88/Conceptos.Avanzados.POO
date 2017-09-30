using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;


namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {


            //Herencia
            //Perros p = new Perros("Perrus Caninus", Genero.Femenino, new PropiedadesAnimal()
            //{
            //    porcentajeAgua = 10,
            //    porcentajeGrasa = 90
            //});
            //Console.WriteLine(p.ToString());
            //Console.ReadKey();
            //Polimorfismo
            //Animal a = new Perro(1, "Perrus Caninus", DateTime.Now);
            //a.sonido();
            //a = new Gato();
            //a.sonido();

            //Animal[] animales = new Animal[2];
            //animales[0] = new Gato();
            //animales[1] = new Perro(2, "Caninus", DateTime.Now);

            //animales[0].sonido();
            //animales[1].sonido();

            // a = new Animal();
            //Abstraccion

            //Animal a = new Perro(1, "Caninus", DateTime.Now);
            //a.sonido();

            //Interfaz
            Perro p = new Perro(1, "Caninus", DateTime.Now);
            p.sonido();
            Roble r = new Roble(2, "Roblius", DateTime.Now);
      



        }
    }
}
