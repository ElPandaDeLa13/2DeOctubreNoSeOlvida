using System;

namespace prueba
{
    class Prueba
    {
        public static void sumaUno(int x)
        {
            x = x+1;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int a=12;
            Prueba.sumaUno(a);
            Console.WriteLine(a);
        }
    }
}
