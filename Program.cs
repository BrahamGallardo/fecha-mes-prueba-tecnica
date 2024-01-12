namespace FechaMes
{
    class Program
    {
        enum NombreMes
        {
            Enero,
            Febrero,
            Marzo,
            Abril,
            Mayo,
            Junio,
            Julio,
            Agosto,
            Septiembre,
            Octubre,
            Noviembre,
            Diciembre
        }
        static void Main()
        {
            DateTime fecha = PideFecha();
            string resultado = ObtenerNombreMes(fecha.Month);
            Console.WriteLine(resultado);
            Console.ReadLine();
        }

        private static DateTime PideFecha()
        {
            DateTime fecha;
            Console.WriteLine("Ingrese la fecha en formato dd/mm/aaaa");
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fecha))
            {
                Console.WriteLine("Formato de fecha invalido, por favor ingrese una fecha en formato dd/mm/aaaa");
            }
            return fecha;
        }

        private static string ObtenerNombreMes(int numeroMes)
        {
            if (numeroMes >= 1 && numeroMes <= 12)
            {
                NombreMes mes = (NombreMes)(numeroMes - 1);
                return mes.ToString();
            }
            else
            {
                throw new ArgumentException("Número de mes inválido");
            }
        }
    }
}