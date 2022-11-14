namespace ejercicio24
{
    public class program
    {
        public static void Main()
        {
            int num1, num2, num3, num4, producto, suma, media;
            Console.WriteLine("por favor escriba 4 numeros enteros ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            num4 = Convert.ToInt32(Console.ReadLine());
            producto = num1 * num2 * num3 * num4;
            suma = num1 + num2 + num3 + num4;
            media = suma / 4;
            Console.WriteLine("el resulado del producto es" + producto);
            Console.WriteLine("el resultado de la suma es " + suma);
            Console.WriteLine("el resultado de la media es " + media);

        }
    }
}
