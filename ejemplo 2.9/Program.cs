namespace ejercicio29
{
    public class program
    {
        public static void Main()
        {
            int horas, vhora, sueldo;
            Console.WriteLine("digite las horas trabajadas");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("digite el valor por hora ");
            vhora = int.Parse(Console.ReadLine());
            sueldo = horas * vhora;
            Console.WriteLine("el sueldo semanal es de"+sueldo);
    }
}