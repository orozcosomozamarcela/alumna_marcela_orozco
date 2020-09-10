using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1_estructura
{
    class Program
    {
        static void Main(string[] args)
        {
            /*tarea 2 Crea un programa que diga el resultado de sumar 200 y 56.
            int numero_A = 200;
            int numero_B = 56;

            int suma;
            suma = numero_A + numero_B;

            Console.WriteLine(" El resultado de sumar 200+56 es : " + suma);
            Console.ReadKey();
            */

            /*tarea 3 Haz un programa que calcule el producto de los números 13 y 12.
            double numero1 = 6.5 * 2;
            double producto_A = numero1;
            int numero2 = 6 * 2; ;
            int producto_B = numero2;
            Console.WriteLine(producto_A) ;
            Console.WriteLine(producto_B);
            Console.ReadLine();
            */


            /*tarea 4 Un programa que calcule la diferencia (resta) entre 321 y 213

            int numero_D = 321;
            int numero_E = 213;

            int resta;
            resta = numero_D - numero_E;

            Console.WriteLine(" El resultado de restar 321-213 es : " + resta);
            Console.ReadKey();
            */

            /*tarea 5 Calcular el resultado de (20+5) % 6

            float n1 = 20;
            float n2 = 5;
            float porcentaje = 0.06;
            float resultado = (n1 + n2) * porcentaje;
            Console.WriteLine(resultado);
            Console.ReadKey();
            */


            /*tarea 6 Crea un programa que calcule el producto de los números 12 y 102, usando variables.

            int numero_Q = 6*2;
            int resultado_Q = numero_Q;
            int numero_W = 51 * 2;
            int resultado_W = numero_W;
            Console.WriteLine(resultado_Q);
            Console.WriteLine(resultado_W);
            Console.ReadKey();
            */

            /*tarea 7 Crea un programa que calcule la suma de 200 y 1111, usando variables.

            int n1 = 100 + 100;
            int resultado_n1 = n1;
            Console.WriteLine("La suma de 100+100 es: " + n1);
            int n2 = 1000 + 111;
            int resultado_n2 = n2;
            Console.WriteLine("La suma de 1000+111 es: " + n2);
            Console.ReadKey();

            */

            /*tarea 8 Crea un programa que calcule el producto de los números 10 y 25, usando
            variables llamadas "numero1" y "numero2"

            int numero1 = 5 * 2;
            int resultado1 = numero1;
            int numero2 = 5 * 5;
            int resultado2 = numero2;
            Console.WriteLine(resultado1);
            Console.Write(resultado2);
            Console.ReadKey();

            */

            /*tarea 9 Crea un programa que calcule el producto de dos números introducidos por el
            usuario.

            int primernumero;
            int segundonumero;
            int producto;
            Console.WriteLine(" introduzca primer numero");
            primernumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" introduzca segundo numero ");
            segundonumero = Convert.ToInt32(Console.ReadLine());
            producto = primernumero * segundonumero;
            Console.WriteLine(" el producto es " + producto);
            Console.ReadKey();

            */

            /* tarea 10 Crea un programa que pida al usuario un número entero y diga si es par (pista: habrá que
            comprobar si el resto que se obtiene al dividir entre dos es cero: if (x % 2 == 0) ...).
            
            Console.WriteLine(" introducir numero entero ");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("el numero " + numero + " es par");
                Console.ReadKey();
            }
            else
            {
               
                Console.ReadKey();

            }

            */

            /*tarea 11 Crea un programa que pida al usuario dos números enteros y diga cuál es el mayor de ellos.
            

            int numero_A;
            int numero_B;
            int mayor;
            Console.WriteLine(" introducir primer numero entero");
            numero_A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" introducir segundo numero entero");
            numero_B = Convert.ToInt32(Console.ReadLine());
            mayor = numero_A > numero_B ? numero_A : numero_B;
            Console.WriteLine(" el numero mayor es " + mayor);
            Console.ReadKey();

            */

            /* tarea 12 Crea un programa que pida al usuario dos números enteros. Si el segundo no es cero, mostrará
            el resultado de dividir entre el primero y el segundo. Por el contrario, si el segundo número es cero,
            escribirá "Error: No se puede dividir entre cero".

            double numero1;
            double numero2;
            Console.WriteLine("intruducir primer numero entero");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introducir segundo numero entero");
            numero2 = Convert.ToInt32(Console.ReadLine());
            if (numero2 != 0)
            {
                Console.WriteLine("El resultado es: " + numero1 / numero2);
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir entre cero");
            }
            Console.ReadKey();

            */

            /*tarea 13 Crea un programa que pida un número del 1 al 5 al usuario, y escriba el nombre de ese
            número, usando "switch"(por ejemplo, si introduce "1", el programa escribirá "uno").

            int numero;

            Console.WriteLine("escribir un numero del 1 al 5");
            numero = Convert.ToInt32(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Console.WriteLine("uno");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("dos");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("tres");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("cuatro");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("cinco");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("no esta dentro del rango del 1 al 5");
                    Console.ReadKey();
                    break;
            }

            */

            /* tarea 14 Crea un programa que escriba en pantalla los números del 1 al 10, usando "while".

            int numero;

            Console.WriteLine("escriba un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            while (numero <= 9)
            {
                numero = numero + 1;
                Console.WriteLine(numero);
            }
            Console.ReadKey();

            */

            /* tarea 15 Crea un programa que escriba en pantalla los números del 1 al 10, usando
             "do..while"
            /*primera solucion*/
            int numero;


            /*Console.WriteLine("escriba un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            do  
            {/*aca va primero el codigo*/
/* numero = numero + 1;
 Console.WriteLine(numero);
}
while (numero <= 9); /*dentro del While va la Condicion

Console.ReadKey();
*/

/*2da solucion del profe:
 * int = 1; 
 * do
 * {
 *   Console.Write(i);
 *   i++;
 * } while (i<=10);
 * Console.ReadKey();

/ tarea 16 Crea un programa que muestre los números del 10 al 20, ambos incluidos, usando “for

int numero;

for (numero = 10; numero <= 20; numero++)
    Console.WriteLine(numero);
Console.ReadKey();



























}
}    
}
