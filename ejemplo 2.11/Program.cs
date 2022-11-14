namespace ejercicio211
{
    public class program
    {
        public static void Main()
        {
            double pago, metro, ancho, largo,altura, precio, preciototal;
            Console.WriteLine("digite el  ancho de la alberca");
            ancho = double.Parse(Console.ReadLine());
            Console.WriteLine("digite el largo que tienen la alberca");
            largo = double.Parse(Console.ReadLine());
            Console.WriteLine("digite la altura de la alberca");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("digite el precio de agua por metro cubico");
            precio= double.Parse(Console.ReadLine());

            metro = ancho*largo*altura;
            preciototal= metro*precio;
            Console.WriteLine("la cantidad de metros cubicos es" + metro);
            Console.WriteLine("el precio para llenar la pscina es de"+preciototal);



        }
    }