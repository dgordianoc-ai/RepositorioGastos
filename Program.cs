namespace RepositorioGastos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GastoRepositorio repositorio = new GastoRepositorio();
            int opcion;

            do
            {
                Console.WriteLine();
                Console.WriteLine("===== REPOSITORIO DE GASTOS =====");
                Console.WriteLine("1. Registrar gasto");
                Console.WriteLine("2. Listar gastos");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = 0;
                }

                switch (opcion)
                {
                    case 1:
                        RegistrarGasto(repositorio);
                        break;

                    case 2:
                        ListarGastos(repositorio);
                        break;

                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 3);
        }

        private static void RegistrarGasto(GastoRepositorio repositorio)
        {
            Console.Write("Descripción: ");
            string descripcion = Console.ReadLine() ?? "";

            Console.Write("Monto: ");
            string textoMonto = Console.ReadLine() ?? "";

            Console.Write("Categoría: ");
            string categoria = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(descripcion) ||
                string.IsNullOrWhiteSpace(categoria) ||
                !decimal.TryParse(textoMonto, out decimal monto) ||
                monto <= 0)
            {
                Console.WriteLine("Datos inválidos.");
                return;
            }

            Gasto gasto = new Gasto
            {
                Descripcion = descripcion,
                Monto = monto,
                Categoria = categoria
            };

            repositorio.Insertar(gasto);

            Console.WriteLine("Gasto registrado.");
        }

        private static void ListarGastos(GastoRepositorio repositorio)
        {
            List<Gasto> gastos = repositorio.ListarTodos();

            if (gastos.Count == 0)
            {
                Console.WriteLine("No hay gastos registrados.");
                return;
            }

            decimal totalGeneral = 0;

            Console.WriteLine();
            Console.WriteLine(
                $"{"Id",-3} {"Descripción",-20} {"Monto",10} {"Categoría",-15}");

            foreach (Gasto gasto in gastos)
            {
                Console.WriteLine(gasto);
                totalGeneral += gasto.Monto;
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL GASTADO: Q {totalGeneral:N2}");
        }
    }
}
