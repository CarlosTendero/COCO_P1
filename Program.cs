using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;  /*tic toc*/

namespace practica1
{
    class Program
    {
        static Stopwatch stopWatch;
        static void Main(string[] args)
        {
            



            byte opcion = 0;            /*variable para el menu, tipo byte ya que tenemos un menu pequenyo*/

            // Vectores que no se ordenan, se copian en los vectores a ordenar
            int[] vector10 = new int[10];                   /*Vector de tamanyo 10*/
            int[] vector100 = new int[100];                 /*Vector de tamnyo 100*/
            int[] vector1000 = new int[1000];               /*Vector de tamanyo 1000*/

            // Vectores que se van a ordenar, copiaremos dentro nuestros arrays aleatorios
            int[] vector10insert = new int[10];             /*Vector de tamanyo 10*/
            int[] vector100insert = new int[100];           /*Vector de tamnyo 100*/
            int[] vector1000insert = new int[1000];         /*Vector de tamanyo 1000*/

            int[] vector10merge = new int[10];              /*Vector de tamanyo 10*/
            int[] vector100merge = new int[100];            /*Vector de tamnyo 100*/
            int[] vector1000merge = new int[1000];          /*Vector de tamanyo 1000*/

            int[] vector10quick = new int[10];              /*Vector de tamanyo 10*/
            int[] vector100quick = new int[100];            /*Vector de tamnyo 100*/
            int[] vector1000quick = new int[1000];          /*Vector de tamanyo 1000*/


            int numoperaciones = 0;                         /*variable para calcular el numero de operaciones en los metodos MergeSort y quickSort*/

            /*Generar vectores*/
            
            /*vector tamanyo 10*/
            GenerarVector(vector10, Convert.ToUInt16(vector10.GetLength(0)));
            /*vector tamanyo 100*/
            GenerarVector(vector100, Convert.ToUInt16(vector100.GetLength(0)));
            /*vector tamanyo 1000*/
            GenerarVector(vector1000, Convert.ToUInt16(vector1000.GetLength(0)));


            do
            {
                Console.WriteLine("\n\n Seleccione una opcion: ");
                Console.WriteLine("1. INSERTION SORT: ");
                Console.WriteLine("2. MERGE SORT: ");
                Console.WriteLine("3. QUICK SORT:");
                Console.WriteLine("4. SALIR:");

                try             // Controlamos que lo introducido sea un numero
                {
                    opcion = Byte.Parse(Console.ReadLine());


                }
                catch (FormatException)
                {
                    opcion = 5;   

                }
                catch (ArgumentNullException)
                {
                    opcion = 5;
                }
                catch (OverflowException)
                {
                    opcion = 5;
                }
                catch (StackOverflowException)
                {
                    opcion = 5;
                }

                switch (opcion)
                {

                    case 1: /*Insertion Sort*/
                        Console.Clear();

                        Tic();

                        // Copiamos vectores estaticos a nuestros vectores a ordenar
                        /*vector tamanyo 10*/
                        CopiaVector(vector10, vector10insert, Convert.ToUInt16(vector10.GetLength(0)));
                        /*vector tamanyo 100*/
                        CopiaVector(vector100, vector100insert, Convert.ToUInt16(vector100.GetLength(0)));
                        /*vector tamanyo 1000*/
                        CopiaVector(vector1000, vector1000insert, Convert.ToUInt16(vector1000.GetLength(0)));

                        /*mostrar vectores*/
                        Console.WriteLine("\nVectores de prueba:\n");
                        /*vector tamanyo 10*/
                        Console.WriteLine("\nVector n = {0}", vector10insert.GetLength(0));                        
                        Imprimir(vector10insert);
                        /*vector tamanyo 100*/
                        Console.WriteLine("\nVector n = {0}", vector100insert.GetLength(0));
                        Imprimir(vector100insert);
                        /*vector tamanyo 1000*/
                        Console.WriteLine("\nVector n = {0}", vector1000insert.GetLength(0));
                        Imprimir(vector1000insert);

                        Console.WriteLine("\nOrdenamiento por insercion (Insertion Sort)");
                        /*Vector de tamanyo 10*/
                        Console.WriteLine("\nOperaciones con vector 10");

                        /*Escenario 1, vector desordenado*/
                        Console.Write("\nEscenario 1: vector desordenado, ");

                        /*Se ordena el vector mediante el metodo InsertionSort y se muestran las operaciones realizadas*/
                   
                        InsertionSort.Ordenamiento(ref vector10insert);
                  
                        /*Se muestra el vector ya ordenado*/
                        Console.WriteLine("\nVector n = {0}", vector10insert.GetLength(0));
                        Imprimir(vector10insert);

                        /*Escenario 2, vector ordenado*/
                        Console.Write("\nEscenario 2: vector ordenado, ");
                        InsertionSort.Ordenamiento(ref vector10insert);

                        /*Se muestra el vector ya ordenado*/
                        Console.WriteLine("\nVector n = {0}", vector10insert.GetLength(0));
                        Imprimir(vector10insert);                                              

                        /*Vector de tamanyo 100*/
                        Console.WriteLine("\n\nOperaciones con vector 100");

                        /*Escenario 1, vector desordenado*/
                        Console.Write("\nEscenario 1: vector desordenado, ");

                        /*Se ordena el vector mediante el metodo InsertionSort y se muestran las operaciones realizadas*/
                        InsertionSort.Ordenamiento(ref vector100insert);

                        /*Se muestra el vector ya ordenado*/
                        Console.WriteLine("\nVector n = {0}", vector100insert.GetLength(0));
                        Imprimir(vector100insert);

                        /*Escenario 2, vector ordenado*/
                        Console.Write("\nEscenario 2: vector ordenado, ");
                        InsertionSort.Ordenamiento(ref vector100insert);

                        /*Se muestra el vector ya ordenado*/
                        Console.WriteLine("\nVector n = {0}", vector100insert.GetLength(0));
                        Imprimir(vector100insert);                                              

                        /*Vector de tamanyo 1000*/
                        Console.WriteLine("\nOperaciones con vector 1000");

                        /*Escenario 1, vector desordenado*/
                        Console.Write("\nEscenario 1: vector desordenado, ");

                        /*Se ordena el vector mediante el metodo InsertionSort y se muestran las operaciones realizadas*/
                        InsertionSort.Ordenamiento(ref vector1000insert);
                      
                        /*Se muestra el vector ya ordenado*/
                        Console.WriteLine("\nVector n = {0}", vector1000insert.GetLength(0));
                        Imprimir(vector1000insert);

                        /*Escenario 2, vector ordenado*/
                        Console.Write("\nEscenario 2: vector ordenado, ");

                        /*Se reordena el vector mediante el metodo InsertionSort y se muestran las operaciones realizadas*/
                        InsertionSort.Ordenamiento(ref vector1000insert);

                        /*Se muestra el vector ya ordenado*/
                        Console.WriteLine("\nVector n = {0}", vector1000insert.GetLength(0));
                        Imprimir(vector1000insert);

                        Toc();  /*tiempo total que tarda en ejecutar todos los algoritmos*/

                        Console.WriteLine("\nPulse cualquier tecla para poder continuar .....");
                        Console.ReadKey();
                        Console.Clear();


                        break;
                    case 2: /*Merge Sort*/


                        numoperaciones = 0;

                        Console.Clear();

                        Tic();
                        // Copiamos vectores estaticos a nuestros vectores a ordenar
                        /*vector tamanyo 10*/
                        CopiaVector(vector10, vector10merge, Convert.ToUInt16(vector10.GetLength(0)));
                        /*vector tamanyo 100*/
                        CopiaVector(vector100, vector100merge, Convert.ToUInt16(vector100.GetLength(0)));
                        /*vector tamanyo 1000*/
                        CopiaVector(vector1000, vector1000merge, Convert.ToUInt16(vector1000.GetLength(0)));

                        /*mostrar vectores*/
                        Console.WriteLine("\nVectores de prueba:\n");
                        /*vector tamanyo 10*/
                        Console.WriteLine("\nVector n = {0}", vector10merge.GetLength(0));
                        Imprimir(vector10merge);
                        /*vector tamanyo 100*/
                        Console.WriteLine("\nVector n = {0}", vector100merge.GetLength(0));
                        Imprimir(vector100merge);
                        /*vector tamanyo 1000*/
                        Console.WriteLine("\nVector n = {0}", vector1000merge.GetLength(0));
                        Imprimir(vector1000merge);

                        /*Vector de tamanyo 10*/
                        Console.WriteLine("\nOperaciones con vector 10");

                        /*Escenario 1, vector desordenado*/
                        Console.Write("\nEscenario 1: vector desordenado, ");

                        /*Se ordena el vector mediante el metodo MergeSort y se guardan las operaciones realizadas*/
                        numoperaciones = MergeSort.Ordenamiento(ref vector10merge, 0, vector10merge.GetLength(0) - 1, numoperaciones);

                        /*Se muestran las operaciones realizadas*/
                        Console.WriteLine("Numero de operaciones: {0}", numoperaciones);

                        /*Se muestra el vector ya ordenado*/
                        Console.WriteLine("\nVector n = {0}", vector10merge.GetLength(0));
                        Imprimir(vector10merge);

                        /*Se reinicializa el numero de operaciones*/
                        numoperaciones = 0;

                        /*Escenario 2, vector ordenado*/
                        Console.Write("\nEscenario 2: vector ordenado, ");

                        /*Se vuelve a ordenar el vector mediante el metodo MergeSort y se guardan las operaciones realizadas*/
                        numoperaciones = MergeSort.Ordenamiento( ref vector10merge, 0, vector10merge.GetLength(0) - 1, numoperaciones);

                        /*Se muestran las operaciones realizadas*/
                        Console.WriteLine("Numero de operaciones: {0}", numoperaciones);

                        /*Se muestra el vector ya ordenado*/
                        Console.WriteLine("\nVector n = {0}", vector10merge.GetLength(0));
                        Imprimir(vector10merge);

                        /*Se reinicializa el numero de operaciones*/
                        numoperaciones = 0;

                        /*----------------------------------------------------------------------------------------------------------------------------------*/

                        /*Vector de tamanyo 100*/
                        Console.WriteLine("\nOperaciones con vector 100");

                        /*Escenario 1, vector desordenado*/
                        Console.Write("\nEscenario 1: vector desordenado, ");

                        /*Se ordena el vector mediante el metodo MergeSort y se guardan las operaciones realizadas*/
                        numoperaciones = MergeSort.Ordenamiento(ref vector100merge, 0, vector100merge.GetLength(0) - 1, numoperaciones);

                        /*Se muestran las operaciones realizadas*/
                        Console.WriteLine("Numero de operaciones: {0}", numoperaciones);

                        /*Se muestra el vector ya ordenado*/
                        Console.WriteLine("\nVector n = {0}", vector100merge.GetLength(0));
                        Imprimir(vector100merge);

                        /*Se reinicializa el numero de operaciones*/
                        numoperaciones = 0;

                        /*Escenario 2, vector ordenado*/
                        Console.Write("\nEscenario 2: vector ordenado, ");

                        /*Se vuelve a ordenar el vector mediante el metodo MergeSort y se guardan las operaciones realizadas*/
                        numoperaciones = MergeSort.Ordenamiento(ref vector100merge, 0, vector100merge.GetLength(0) - 1, numoperaciones);

                        /*Se muestran las operaciones realizadas*/
                        Console.WriteLine("Numero de operaciones: {0}", numoperaciones);

                        /*Se muestra el vector ya ordenado*/
                        Console.WriteLine("\nVector n = {0}", vector100merge.GetLength(0));
                        Imprimir(vector100merge);

                        /*Se reinicializa el numero de operaciones*/
                        numoperaciones = 0;


                        /*----------------------------------------------------------------------------------------------------------------------------------*/

                        /*Vector de tamanyo 1000*/
                        Console.WriteLine("\nOperaciones con vector 1000");

                        /*Escenario 1, vector desordenado*/
                        Console.Write("\nEscenario 1: vector desordenado, ");

                        /*Se ordena el vector mediante el metodo MergeSort y se guardan las operaciones realizadas*/
                        numoperaciones = MergeSort.Ordenamiento(ref vector1000merge, 0, vector1000merge.GetLength(0) - 1, numoperaciones);

                        /*Se muestran las operaciones realizadas*/
                        Console.WriteLine("Numero de operaciones: {0}", numoperaciones);

                        /*Se muestra el vector ya ordenado*/
                        Console.WriteLine("\nVector n = {0}", vector1000merge.GetLength(0));
                        Imprimir(vector1000merge);

                        /*Se reinicializa el numero de operaciones*/
                        numoperaciones = 0;

                        /*Escenario 2, vector ordenado*/
                        Console.Write("\nEscenario 2: vector ordenado, ");

                        /*Se vuelve a ordenar el vector mediante el metodo MergeSort y se guardan las operaciones realizadas*/
                        numoperaciones = MergeSort.Ordenamiento(ref vector1000merge, 0, vector1000merge.GetLength(0) - 1, numoperaciones);

                        /*Se muestran las operaciones realizadas*/
                        Console.WriteLine("Numero de operaciones: {0}", numoperaciones);

                        /*Se muestra el vector ordenado*/
                        Console.WriteLine("\nVector n = {0}", vector1000merge.GetLength(0));
                        Imprimir(vector1000merge);


                        Toc();/*Tiempo total en hacer todos los algoritmos*/

                        Console.WriteLine("\nPulse cualquier tecla para poder continuar .....");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 3: /*Quick Sort*/

                        /*inicializamos el numero de operaciones*/
                        numoperaciones = 0;

                        Console.Clear();

                        Tic();

                        // Copiamos vectores estaticos a nuestros vectores a ordenar
                        /*vector de tamanyo 10*/
                        CopiaVector(vector10, vector10quick, Convert.ToUInt16(vector10.GetLength(0)));
                        /*vector de tamanyo 100*/
                        CopiaVector(vector100, vector100quick, Convert.ToUInt16(vector100.GetLength(0)));
                        /*vector de tamanyo 1000*/
                        CopiaVector(vector1000, vector1000quick, Convert.ToUInt16(vector1000.GetLength(0)));

                        /*mostrar vectores*/
                        Console.WriteLine("\nVectores de prueba:\n");
                        /*Vector de tamanyo 10*/
                        Console.WriteLine("\nVector n = {0}", vector10quick.GetLength(0));
                        Imprimir(vector10quick);
                        /*Vector de tamanyo 100*/
                        Console.WriteLine("\nVector n = {0}", vector100quick.GetLength(0));
                        Imprimir(vector100quick);
                        /*Vector de tamanyo 1000*/
                        Console.WriteLine("\nVector n = {0}", vector1000quick.GetLength(0));
                        Imprimir(vector1000quick);

                        /*Vector de tamanyo 10*/
                        Console.WriteLine("\nOperaciones con vector 10");

                        /*Escenario 1, vector desordenado*/
                        Console.Write("Escenario 1: vector desordenado, ");

                        /*Se ordena el vector mediante el metodo QuickSort y se guardan las operaciones realizadas*/
                        numoperaciones = QuickSort.Ordenamiento(ref vector10quick, 0, vector10quick.GetLength(0) - 1, numoperaciones);

                        /*Se muestran las operaciones realizadas*/
                        Console.WriteLine("\nNumero de operaciones: {0}", numoperaciones);

                        /*Se muestra el vector ya ordenado*/
                        Console.WriteLine("\nVector n = {0}", vector10quick.GetLength(0));
                        Imprimir(vector10quick);

                        /*Se reinicializa el numero de operaciones*/
                        numoperaciones = 0;

                        /*Escenario 2, vector ordenado*/
                        Console.Write("Escenario 2: vector ordenado, ");

                        /*Se vuelve a ordenar el vector mediante el metodo QuickSort y se guardan las operaciones realizadas*/
                        numoperaciones = QuickSort.Ordenamiento(ref vector10quick, 0, vector10quick.GetLength(0) - 1, numoperaciones);

                        /*Se muestran las operaciones realizadas*/
                        Console.WriteLine("\nNumero de operaciones: {0}", numoperaciones);

                        /*Se muestra el vector ordenado*/
                        Console.WriteLine("\nVector n = {0}", vector10quick.GetLength(0));
                        Imprimir(vector10quick);

                        /*Se reinicializa el numero de operaciones*/
                        numoperaciones = 0; 

                        /*---------------------------------------------------------------------------------------------------------------------------*/
                        
                        /*Vector de tamanyo 100*/
                        Console.WriteLine("\nOperaciones con vector 100");

                        /*Escenario 1, vector desordenado*/
                        Console.Write("Escenario 1: vector desordenado, ");

                        /*Se ordena el vector mediante el metodo QuickSort y se guardan las operaciones realizadas*/
                        numoperaciones = QuickSort.Ordenamiento(ref vector100quick, 0, vector100quick.GetLength(0) - 1, numoperaciones);

                        /*Se muestran las operaciones realizadas*/
                        Console.WriteLine("\nNumero de operaciones: {0}", numoperaciones);

                        /*Se muestra el vector ya ordenado*/
                        Console.WriteLine("\nVector n = {0}", vector100quick.GetLength(0));
                        Imprimir(vector100quick);

                        /*Se reinicializa el numero de operaciones*/
                        numoperaciones = 0;

                        /*Escenario 2, vector ordenado*/
                        Console.Write("Escenario 2: vector ordenado, ");

                        /*Se vuelve a ordenar el vector mediante el metodo QuickSort y se guardan las operaciones realizadas*/
                        numoperaciones = QuickSort.Ordenamiento(ref vector100quick, 0, vector100quick.GetLength(0) - 1, numoperaciones);

                        /*Se muestran las operaciones realizadas*/
                        Console.WriteLine("\nNumero de operaciones: {0}", numoperaciones);

                        /*Se muestra el vector ordenado*/
                        Console.WriteLine("\nVector n = {0}", vector100quick.GetLength(0));
                        Imprimir(vector100quick);                                              

                        /*Se reinicializa el numero de operaciones*/
                        numoperaciones = 0; 

                        /*--------------------------------------------------------------------------------------------------------------------------*/
                       
                        /*Vector de tamanyo 1000*/
                        Console.WriteLine("\nOperaciones con vector 1000");

                        /*Escenario 1, vector desordenado*/
                        Console.Write("Escenario 1: vector desordenado, ");

                        /*Se ordena el vector mediante el metodo QuickSort y se guardan las operaciones realizadas*/
                        numoperaciones = QuickSort.Ordenamiento(ref vector1000quick, 0, vector1000quick.GetLength(0) - 1, numoperaciones);

                        /*Se muestran las operacioens realizadas*/
                        Console.WriteLine("\nNumero de operaciones: {0}", numoperaciones);

                        /*Se muestra el vector ya ordenado*/
                        Console.WriteLine("\nVector n = {0}", vector1000quick.GetLength(0));
                        Imprimir(vector1000quick);     
                        
                        /*reinicializamos a 0 el numero de operaciones*/
                        numoperaciones = 0;
                       
                        /*Escenario 2, vector ordenado*/
                        Console.Write("Escenario 2: vector ordenado, ");

                        /*Se vuelve a ordenar el vector mediante el metodo QuickSort y se guardan las operaciones realizadas*/
                        
                        numoperaciones = QuickSort.Ordenamiento(ref vector1000quick, 0, vector1000quick.GetLength(0) - 1, numoperaciones);

                        /*Se muestran las operacioens realizadas*/
                        Console.WriteLine("\nNumero de operaciones: {0}", numoperaciones);

                        /*Se muestra el vector ordenado*/
                        Console.WriteLine("\nVector n = {0}", vector1000quick.GetLength(0));
                        Imprimir(vector1000quick);

                        Toc();/*tiempo total en hacer todos los algoritmos*/

                        Console.WriteLine("\nPulse cualquier tecla para poder continuar .....");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 4:         /*SALIR*/
                        Console.WriteLine("HASTA LA PROXIMA!");
                        break;

                    default:        /*Si no se ha introducido una de las posibles opciones*/
                        Console.WriteLine("Opcion no valida por favor seleccione una opcion dentro del Menu");
                        break;

                }


            } while (opcion != 4); /*mientras opcion sea distinta de Salir*/



            Console.ReadKey();



            }    

        /*Funcion Imprimir
          Descripcion:
          Muestra por pantalla el vector que pasamos como parametro de la funcion
          Parametro:
          int[] array: Vector cuyos valores se mostraran por pantalla
         */


        public static void Imprimir(int[] array) {

            Console.Write("{");/*LLave inicial*/

            for (uint i = 0; i < array.GetLength(0); i++)
            {
                if (i != array.GetLength(0) - 1)
                    Console.Write("{0},", array[i]);       /*Mostramos los valores por pantalla*/
                else
                    Console.WriteLine(array[i] + "}");     /*Ultimo valor del vector*/
            }

        }

        /*Funcion GenerarVector
         Descripcion:
         Genera numeros aleatorios que se alamcenaran dentro del vector que se pasa como parametro de la funcion
         Parametros:
         int [] vector: vector donde se almaceraran los datos aleatorios generados
         uint longitud: longitud del vector
        */

        public static void GenerarVector(int[] vector, uint longitud)/*no pueden existir longitudes negativas*/
        {
            /*Objeto de clase Random para poder generar numeros aleatorios*/
            Random r = new Random();

            for (uint i = 0; i < longitud; i++)
                vector[i] = r.Next(1, 101); /*genera numeros aleatorios entre 1-100*/

            r = null;  /*liberamos el objeto*/

        }


        /*Funcion CopiaVector
        Descripcion:
        Copia los datos de un vector en otro
        Parametros :
        int[] vector: vector original
        int [] vectorOrdenamiento: vector destino
        uint longitud: la longitud de ambos vectores
        */
        public static void CopiaVector(int[] vector, int[] vectorOrdenamiento, uint longitud)/*no pueden existir longitudes negativas*/
        {
            
            for (uint i = 0; i < longitud; i++)
                vectorOrdenamiento[i] =vector[i];   /*actualiza los datos del vector destino*/

        }


        public static void Tic()
        {
            stopWatch = new Stopwatch();
            stopWatch.Start();

        }

        public static void Toc()
        {
            TimeSpan ts = stopWatch.Elapsed;

            /*la cadena a mostrar por pantalla y el formato que usamos*/
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",ts.Hours, ts.Minutes, ts.Seconds,ts.Milliseconds / 10);

            /*mostramos tiempo que transcurre hasta que ejecuta el ultimo "tic" */
            Console.WriteLine($"tiempo de ejecucion : {elapsedTime} ");

        }




    }
}
