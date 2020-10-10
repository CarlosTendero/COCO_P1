using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practica1
{
    class MergeSort
    {
        /*Funcion Mezclar
         Descripcion:
         Ordena de menor a mayor el subarray creado por el limite superior e inferior que le pasamos
         Parametros:
         ref int [] vector: vector que se pasa por referencia a ordenar
         int limInf: el limite inferior del vector que se le pasa para crear un "subarray"
         int limSup: el limite superior del vector que se le pasa para crear un "subarray"
         int operaciones: acumulador donde se guarda el numero de operaciones, despues devolvemos este valor
         */
        public static int Mezclar(int[] vector, int limInf, int medio, int limSup, int operaciones) // Mezcla dos sub arrays 
        {

            // Creamos variables auxiliares con nuestros datos de los parametros
            int izq = limInf;
            int der = medio + 1;

            // Un vextor auxiliar que permite ordenar nuestros subsarrays
            int[] aux = new int[(limSup - limInf) + 1];

            // indice auxiliar para recorrer el array
            int auxInd = 0;

            // Bucle que recorre el subarray formado por elmInf y limSup
            while (izq <= medio && der <= limSup)
            {
                // Compara el valor de la posicion izq del vector con el de la posicion der
                if (vector[izq] < vector[der])
                {
                    aux[auxInd] = vector[izq];
                    izq++;
                    operaciones += 3; /*comparacion, asignacion e incremento*/
                }
                else/*esta desordenado*/
                {
                    aux[auxInd] = vector[der];
                    der++;
                    operaciones += 3; /*comparacion, asignacion e incremento*/
                }
                auxInd++;   /*incrementamos la variable auxilizar*/
                operaciones += 4;
            }

            while (izq <= medio)/*si cuelgan algunos elementos*/
            {
                aux[auxInd] = vector[izq];
                izq++;
                auxInd++;
                operaciones += 4;/*comparacion, asignacion e incrementos*/
            }


            while (der <= limSup)/*si cuelgan algunos elementos*/
            {
                aux[auxInd] = vector[der];
                der++;
                auxInd++;
                operaciones += 4;/*comparacion, asignacion e incrementos*/
            }

            for (int i = 0; i < aux.GetLength(0); i++)/*Se recolocan en el array*/
            {
                vector[limInf + i] = aux[i];
                operaciones += 3;   /*comparacion for, incremento de i, asignacion*/
            }


            operaciones += 9;

            return operaciones; /*se devuelve el numero de operaciones*/

        }

        /*Funcion Ordenamiento
        Descripcion: llamamos recursivamente a este metodo para "particionar" 
        nuestro vector y llama a la funcion Mezcla que colocara cada elemento en su posicion
        Parametros:
        ref int[] vector
        int limInf: el limite inferior, varia para "particionar"
        int limSup: el limite superior, varia para "particionar"
        int operaciones: acumulador donde se guarda el numero de operaciones, despues devolvemos este valor
        */
        public static int Ordenamiento( ref int[] vector, int limInf, int limSup, int operaciones)
        {

            if (limInf < limSup)                                // Comprobamos que no sea un vector de 1 posicion
            {
                
                

                // Llamamos recursivamente para "partir" el vector a la mitad  mitad = (limSup + limInf) / 2;
                Ordenamiento( ref vector, limInf, (limSup + limInf) / 2, operaciones);            // Primera mitad
                Ordenamiento( ref vector, ((limSup + limInf) / 2) + 1, limSup, operaciones);        // Segunda mitad

                // Llamamos al metodo mezclar y se ira llamando como veces se llame recursivamente la funcion, ordenando y mezclando los vectores 
                operaciones +=  Mezclar(vector, limInf, (limSup + limInf) / 2, limSup, operaciones) + 5; /*comparacion del if, operaciones arimeticas en las llamadas a funciones*/
            }
            
            return operaciones + 1; /* +1 por la comparacion del if*/

        }


    }
}
