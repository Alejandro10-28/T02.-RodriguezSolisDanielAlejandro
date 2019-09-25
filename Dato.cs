using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    class Dato
    {
        public void ObtenerDatos()
        {
            Console.WriteLine("Hola, bienvenido a mi programa");//Bienvenida al programa
            Console.ReadKey();
            Console.WriteLine("Para iniciar presione cualquier número en su teclado:");//Se presiona cualquier numero del teclado para empezar
            Operaciones op = new Operaciones();//Se instancia operaciones para mandar a los metodos
            //los datos que el usuario ingrese 
            
            int m =Convert.ToInt32( Console.ReadLine());//Se crea la variable m para tener el control del ciclo do while

            do
            {
                //Se piden los datos correspondientes al tipo de parametros que se van a ejecutar.
                Console.WriteLine("Ingresa los valores a multiplicar por dos parametros:");
                Console.WriteLine("Valor a:");
                double Cool = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Valor b");
                double cool2 = Convert.ToDouble(Console.ReadLine());
                double Res = op.Multiplicar(Cool, cool2);//Se manda como parametros los valores ingresados
                Console.ReadKey();
                Console.Clear();

                //Se piden tres valores para la operación con 3 parametros.
                Console.WriteLine("Ingresa los valores a multiplicar por 3 parametros:");
                Console.WriteLine("Valor a:");
                double Cool3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Valor b:");
                double cool4 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Valor c:");
                double Cool5 = Convert.ToDouble(Console.ReadLine());
                double Res1 = op.Multiplicar(Cool3, cool4, Cool5);//Se mandan como parametro los tres datos ingresados
                Console.ReadKey();
                Console.Clear();
                //Se pide un valor para la operación con 1 parametro.
                Console.WriteLine("Ingresa valor a multiplicar por 1 parametro(El valor se multiplicara por el determinado 5):");
                Console.WriteLine("Valor a:");
                double Cool6 = Convert.ToDouble(Console.ReadLine());
                double Res2 = op.Multiplicar(Cool6);//Se manda como parametro el valor ingresado
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("¿Quieres repetir?\n1.si\n2.no");//Se da la opción al usuario si gusta continuar con el ciclo.
                m=Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (m != 2);//El ciclo se repetira hasta cuando el usuario elija el 2.


        }   
    }
}
