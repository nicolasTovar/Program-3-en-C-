using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Nombre del programa: Program3 
  Nombre: Juan Nicolas Tovar Puentes
  Fecha: 02/07/2019 
  Descripción: El Program3 sirve para hallar los parametros de recreación lineal y coheficiente de cancelación.
  Lenguaje de programación: el lenguaje de programación es C#
 */

namespace Program3
{
    class Auxiliar
    {
        public void calcular()
        {
            //Las variables i,j,a,q,w son los contadores y son un tipo de datos int.
            // Las variables contador,numero1,numero2,resultado,resultado2,acumuladorX,acumuladorY,potenciaX,potenciaY,xy,beta1,beta2,beta3,beta,acumuladorYk,acumuladorRxy,acumulador,acumulador2,acumulador3,acumuladorR almacenan resultados y son tipo de dato double.
            // Los arreglos su longitud de 10 posiciones
            int i, j,w;
            double contador=0,numero1 = 0, numero2 = 0, resultado = 0, resultado2 = 0, acumuladorX = 0, acumuladorY = 0, potenciaX = 0, potenciaY = 0, xy = 0,suma=0;
            double beta1 = 0,beta2=0,beta3=0, beta = 0, acumuladorYk = 0, acumuladorRxy = 0,acumulador2=0,acumulador=0,acumuladorR=0 ;
            double[] arregloTabla1 = new double[11];
            double[] arregloTabla2 = new double[11];
            double[] arregloTabla3 = new double[11];
      

           

                Console.WriteLine("Digite la cantidad de número que quiere ingresar: ");
                contador = Convert.ToDouble(Console.ReadLine());

            //En la variable numero1 almacena los datos ingresados, en el arregloTabla1[i] almacena cada posición de los  datos ingresados y la variable resultado almacena la suma de los datos.
            //En la variable potenciaX almacena los numeros almacenados elevado al cuadrado.
            //En la variable acumuladorX se almacena el promedio de los datos ingresados. 

            for (i = 1; i <= contador; i++)
            {
              
                Console.WriteLine("Digite un número en la tabla x: ");
                numero1 = Convert.ToDouble(Console.ReadLine());
                arregloTabla1[i] = numero1;
                potenciaX = potenciaX+Math.Pow(numero1,2);
                resultado = resultado +numero1;
                acumuladorX = resultado / contador;
               
            }
            Console.WriteLine("Promedio de la tabla x: " + acumuladorX);
            Console.WriteLine("Número elevado: " + potenciaX);

            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            //En la variable numero2 almacena los datos ingresados, en el arregloTabla2[j] almacena cada posición de los  datos ingresados y la variable resultado almacena la suma de los datos.
            //En la variable potenciaY almacena los numeros almacenados elevado al cuadrado.
            //En la variable acumuladorY se almacena el promedio de los datos ingresados. 
            for (j = 1; j <= contador; j++)
            {
             
                Console.WriteLine("Digite un número en la tabla y: ");
                numero2 = Convert.ToDouble(Console.ReadLine());
                arregloTabla2[j] = numero2;
                potenciaY =potenciaY+ Math.Pow(numero2,2);
                resultado2 = resultado2 + numero2;
                acumuladorY = resultado2 / contador;
            }
            Console.WriteLine("Promedio de la tabla y: " + acumuladorY);
            Console.WriteLine("Número elevado: " + potenciaY);
       
            
             //En la variable xy almacena el resultado de los número ingresados en la tabla y * la tabla x.   
             // En la variable suma almacena la suma de los números multiplicados.
             //En el arregloTabla5[q] guarda en posiciones los resultados.
             for (w = 1; w <= contador; w++)
             {
                xy = arregloTabla1[w] * arregloTabla2[w];
                suma = suma + xy;
                arregloTabla3[w] = suma;
             
             }
            Console.WriteLine("multiplicacion: " + suma);


            //En la variable beta1 almacena el resultado para hallar la beta1
            beta2 = (suma) - (contador * acumuladorX * acumuladorY);
            beta3=(potenciaX)-(contador*Math.Pow(acumuladorX,2));
            beta1 = beta2 / beta3;
            Console.WriteLine("¿Cuál es la B1? " + beta1);
           
             //En la variable beta almacena el resultado para hallar la beta
            beta = acumuladorY - beta1 * acumuladorX;
            Console.WriteLine("¿Cuál es la B0? " + beta);
          
               //En la variable acumuladorYk almacena el resultado para hallar Yk
            acumuladorYk = beta + beta1 * 386;
            Console.WriteLine("¿Cuál es la Yk? " + acumuladorYk);
            

            //En la variable acumuladorRxy almacena el Rxy
             acumulador = (contador * suma) - (resultado * resultado2);
             acumulador2 = (((contador * potenciaX) - Math.Pow(resultado, 2))*((contador * potenciaY) - Math.Pow(resultado2, 2)));
             acumuladorRxy = acumulador/Math.Sqrt(acumulador2);
            Console.WriteLine("¿Cuál es la Rxy? " + acumuladorRxy);
            //En la variable acumuladorR almacena el Rxy al cuadrado 
            acumuladorR = Math.Pow(acumuladorRxy, 2);
            Console.WriteLine("¿Cuál es la R² ? " + acumuladorR);
            Console.ReadKey();
        }
    }
}
