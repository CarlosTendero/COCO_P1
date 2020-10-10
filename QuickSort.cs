using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practica1
{
    class QuickSort
    {

        public static int particion(int[] vector, int limInf, int limSup, ref int operacion) {

            // Seleccion del pivote
            int pivote = vector[limSup];

            // variables temporales
            int temp;
            int temp1;
            // Indice del elemento en la posicion mas pequenya 
            int i = (limInf - 1);

            operacion += 5;

            for (int j = limInf; j < limSup; j++)
            {
                // Si el elemento en el que estamos es mas pequenyo o igual que el pivote  
                if (vector[j] <= pivote)
                {
                    i++;

                    // Intercambia vector[i] y vector[j] 
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    operacion += 5; /*comparacion, incremento, asignaciones*/
                }
                operacion++;
            }
            
            // Intercambia vector[i+1] y vector[limSup] (o pivote) 
            temp1 = vector[i + 1];
            vector[i + 1] = vector[limSup];
            vector[limSup] = temp1;

            operacion += 5;

            return i + 1;   // devuelve posicion correcta del pivote
        }

        public static int Ordenamiento(ref int[] vector, int limInf, int limSup, int operaciones)
        {


            if (limInf < limSup)  // Comprobamos que no sea un vector de 1 posicion
            {

                /* calcumamos nuesrtro pivote */
                int pi = particion(vector, limInf, limSup, ref operaciones);

                Ordenamiento(ref vector, limInf, pi - 1, operaciones);/*Se ordena por la Izquierda del pivote*/
                Ordenamiento(ref vector, pi + 1, limSup, operaciones);/*Se ordena por la derecha del pivote*/
            }

            return operaciones + 1;/*+1 por la comparacion del if*/

        }

        

    }
}
