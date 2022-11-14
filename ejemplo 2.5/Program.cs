namespace ejercicio25
{
    public class program
    {
        public static void Main ()
        {
            decimal a, b, c, ab, cd, area;
            Console.WriteLine("por favor digite la longitud de A");
            a= decimal.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la longitud de B");
            b= decimal.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la longitud de C");
            c= decimal.Parse(Console.ReadLine());
            ab = b * c;
            cd = ((a - c) * b) / 2;
            area = ab * cd;
        }
    }
}
