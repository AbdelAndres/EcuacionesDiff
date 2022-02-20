using System;

namespace Ecuaciones_diferenciales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo metodo euler para ecuaciones diferenciales
            //Datos
            double x0 = 1;
            double y0 = 0.5;
            double h = 0.01;
            int n = 10;

            double[] X = new double[n + 1];
            double[] Y = new double[n + 1];
            X[0] = x0;
            Y[0] = y0;
            for(int i=0;i<n;i++)
            {
                X[i + 1] = X[i] + h;
                Y[i + 1] = Y[i] + h * -(Math.Pow(Y[i],3) + 2 * X[i] * Y[i]) / (3 * X[i] *(Math.Pow(Y[i],2)) + (Math.Pow(X[i],2)));
            }
            Console.WriteLine("Las soluciones Y(t) aproximadas por el metodo de euler son:");
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(Y[i]);
            }
               
        }
    }
}
