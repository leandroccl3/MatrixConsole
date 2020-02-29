using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//System es un espacio de nombre que contiene clases  
namespace MatrixConsole //nombre del programa
{
    class Program //nombre de la clase
    {
        static void Main(string[] args) //nombre del método (este es el principal)
        {
            byte edad = 20;
            //edad = Convert.ToByte(edad + 10); 
            edad += 20;// esta linea es equivalente a la linea superior, solo que utilizando el operador de asignación
            int salario = 20000;
            double inflacion = 56.25;
            bool dinero = false;
            string nombre = "Leandro";
                        //dinamic trata de adivinar que tipo de dato es
            Console.WriteLine("El valor de la edad es " +edad +" y su salario es " +salario +" el valor de la inflación es " +inflacion + " y la persona " + dinero + " plata y su nombre es " +nombre);
            Console.ReadKey();

            double bas, exponente, potencia;

            Console.WriteLine("Indique la base: ");
            bas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indique el exponente: ");
            exponente = Convert.ToDouble(Console.ReadLine());

            potencia = Math.Pow(bas, exponente);
            Console.WriteLine("El valor de la potencia es: " +potencia);
            Console.ReadKey();
            double peso;
            Console.Write("Ingrese su peso en kilogramos: ");
            peso = Convert.ToDouble(Console.ReadLine());
            if (peso>100){
                Console.WriteLine("Debes controlar tu peso");
                    }
            else
            {
                Console.WriteLine("Sigue así que vas bien");
            }
            Console.ReadKey();
        }
    
    }
}
