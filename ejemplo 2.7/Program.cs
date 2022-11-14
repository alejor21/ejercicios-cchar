namespace ejercicio27
{
    public class program
    {
        public static void Main ()
        {
            double num1 = 3.785;
            double num2,num3,num4,num5;
            Console.WriteLine("por favor digite los litros de la venta");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite el precio del galon ");
            num3 = double.Parse(Console.ReadLine());
            num4 = num2 / num1;
            num5 = num4 * num3;
            Console.WriteLine(" el valor de ventas es " + num5);
            Console.WriteLine("la cantidad de galones es " + num4);
        }
    }
}