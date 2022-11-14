namespace ejercicio210
{
    public class program
    {
        public static void Main()
        {
           
            double metro = 0.0254;
            double pulgs = 0;
            double mtela= 0;
            Console.WriteLine("digite la cantidad de metros de tela ");
            mtela = double.Parse(Console.ReadLine());
            pulgs = mtela/metro;
            Console.WriteLine("la cantidad de metros en pulgadas es" + pulgs);


        }
    }
}