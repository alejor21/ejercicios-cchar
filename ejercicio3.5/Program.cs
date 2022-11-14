namespace ejercicio35
{
    public class program
    {
        public static void Main()
        {
            double factura, descuento, precio, preciobruto, iva, ivacompra;
            int cantidadprod;
            Console.WriteLine("ingrese el precio del producto ");
            precio = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la cantidad de producto que va a llevar");
            cantidadprod= int.Parse(Console.ReadLine());

            ivacompra = (precio * cantidadprod) * 0.12;
            Console.WriteLine("el iva tienen un valor de "+ivacompra);

            preciobruto = precio * cantidadprod * ivacompra;

            if (preciobruto > 50000)
            {
                descuento = preciobruto * 0.05;
                factura = preciobruto - descuento;
            }
            else
            {
                factura = preciobruto;
            }
            Console.WriteLine("el valor total de la factura es "+factura);
        }
    }
}
