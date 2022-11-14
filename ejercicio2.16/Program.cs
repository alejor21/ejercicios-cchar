namespace ejercici216
{
    public class program
    {
        public static void Main()
        {
            int cont;
            int limite;
            int sumatoria;
            sumatoria = 0;
            cont = 1;
            limite = 10;
            for (cont = 3; cont <= limite; cont ++) ;
            {
                sumatoria = sumatoria + cont;
                Console.WriteLine("el resultado de la suma de los numeros es" + sumatoria);
            }
        }
    }
}
