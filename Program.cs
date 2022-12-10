using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lab02_RecursivoFibonacci;
class Program
{
    // Autor: Daniel Mera

    static void Main(string[] args)
    {
        int n, k;
        Stopwatch time = new Stopwatch(); // reloj para medir el tiempo
        Program program= new Program();

        do
        {
            Console.WriteLine("Introduzca el número de términos: ");
            n = int.Parse(Console.ReadLine());
        } while (n <= 1);

        // Llamada al metodo recursivo
        Console.WriteLine("Serie de números de fibonacci recursivo: ");
        time.Start(); // inicia a tomar el tiempo
        for (k = 0; k < n; k++)
        {
            Console.Write(program.FibonacciRecursivo(k) + " ");
        }
        time.Stop(); // Detiene el reloj
        Console.WriteLine("\n- Tiempo de ejecución: " + time.Elapsed.TotalSeconds + " seg \n");

        // Llamada al metodo iterativo
        time.Reset(); // Reiniciar el tiempo
        time.Start(); // inicia a tomar el tiempo
        Console.WriteLine("Serie de números de fibonacci iterativo: ");
        program.FibonacciIterativo(n);
        time.Stop(); // Detiene el relojs
        Console.WriteLine("\n- Tiempo de ejecución: " + time.Elapsed.TotalSeconds + " seg \n");
    }

    // Metodo Recursivo
    long FibonacciRecursivo(int n)
    {
        if(n<2) 
        {
            return n;
        }else{
            return FibonacciRecursivo(n-2) + FibonacciRecursivo(n-1);
        }
    }

    // Metodo Iterativo
    void FibonacciIterativo(int n)
    {
        int i;
        long ant1, ant2;
        ant1 = ant2 = 1;
        Console.Write("0 1 1 ");
        for(i = 1; i < n-2; i++)
        {
            long actual = ant1 + ant2;
            Console.Write(actual + " ");
            ant2 = ant1;
            ant1 = actual;
        }
    }
}
