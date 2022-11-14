namespace ejercicio23
{
    public class program
    {
        public static void Main()
        {
            int numero, resultado, doblado;
            Console.WriteLine("digite un nnumero entero");
            numero = Convert.ToInt32(Console.ReadLine());
            doblado = numero * 2;
            resultado = numero * 25;
            Console.WriteLine("el numero doblado es " + doblado);
            Console.WriteLine("el numero multiplicado por 25 es" + resultado);

        }
    }
}