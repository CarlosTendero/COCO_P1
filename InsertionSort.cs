using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practica1
{
    class InsertionSort
    {

        /*Funcion Ordenamiento
         Descripcion:
         Ordena de menor a mayor
         Parametros:
         ref int [] vector: vector que se pasa por referencia a ordenar
         */
        public static void Ordenamiento(ref int[] vector)
        {
            int x = 0, j = 0;
            int operaciones = 0;    /*inicializamos las variables*/
            for (int i = 1; i < vector.GetLength(0); i++)
            {            
                x = vector[i];      /*asignamos en x un valor del vector*/
                j = i - 1;
                

                while ((j >= 0) && (vector[j] > x))     /*j mayor que cero y que el valor del vector en la posicion j sea mayor que el valor x*/
                {
                    vector[j + 1] = vector[j];          
                    j--;
                    operaciones += 5;                   /*actualiza el numero de operaciones comparacion de j, comparacion de vector[j], comparacion &&, asignacio vector[j+1] y decremento de j*/
                }
                vector[j + 1] = x;                      /*asignacion */
                operaciones += 5;                       /*comparacion for, incremento de i, asignacion x, asignacion j y asignacion vector[j+1]*/
            }

            operaciones++;/*asignacion primera de la i del bucle for*/
            operaciones += 2; /*ultima comparacion, que sale del bucle, y ultimo incremento de i*/
            Console.WriteLine("operaciones realizadas: {0}", operaciones);  /*se muestran las operaciones*/

           
               

        }
    }
}
