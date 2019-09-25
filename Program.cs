using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se instancia la clase Dato para acceder al metodo ObtenerDatos donde se guarda el procedimiento
            Dato sd = new Dato();
            sd.ObtenerDatos();
            Console.ReadKey();
            
            // Operaciones op= new Operaciones();
            // double resultado1=op.Multiplicar1(2,3,4) ;
            //Console.WriteLine("El resultado es:"+ resultado1);
            //Console.ReadKey();
            //double resultado2 = op.Multiplicar2(2,3);
            //Console.WriteLine("El resultado es:"+resultado2);
            //Console.ReadKey();
            //double resultado3 = op.Multiplicar3(2);
            //Console.WriteLine("El resultado es:"+ resultado3);
            //Console.ReadKey();
            
       }
    }
}
