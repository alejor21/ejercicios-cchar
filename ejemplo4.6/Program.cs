using System;

namespace ejemplo46
{
    public class program
    {
        public static void Main()
        {
            double cantidad, cantidadAño = 0, ahorroMes;

            for (int i = 1; i < 13; i++)
            {

                Console.WriteLine("Proceso " + i);
                Console.WriteLine("Digite el valor a depositar");

                cantidad = double.Parse(Console.ReadLine());
                cantidadAño = cantidadAño + cantidad;
                ahorroMes = cantidadAño;

                Console.WriteLine("El valor de la cantidad del mes es de " + ahorroMes);
            }
            Console.WriteLine("el ahorro de un año es de "+cantidadAño);
        
        
        }
    }
}