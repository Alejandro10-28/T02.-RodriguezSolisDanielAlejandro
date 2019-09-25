using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
      public class Operaciones
    {
        double S;
        //Se crean los 3 metodos con sobrecarga, estos se llamaran igual con la unica diferencia en sus parametros.
        public double Multiplicar(double a,double b,double c)//Se crea el metodo que contendra 3 parametros
        //se crean los 3 parametros de tipo double.
        {
             S = a*b*c;//Se crea una variable de tipo double para guardar el resultado del calculo
            Console.WriteLine("El resultado es:" + S);

            return S;//Se retorna el valor que contiene S de vuelta a la clase datos donde se guardara el resultado para
            //imprimirse.
        }
        //Se crea el segundo metodo que llevara 2 parametros
        public double Multiplicar(double a, double b)
        {
            S = a * b;
            Console.WriteLine("El resultado es:" + S);


            return S;


        }
        //Se crea el tercer metodo que llevara 1 parametro
        public double Multiplicar(double a)
        {
             S = a*5;
            Console.WriteLine("El resultado es:" + S);

            return S;
        }
    }
}
