
using Microsoft.Data.SqlClient;

namespace RepositorioGastos
{
    public class GastoRepositorio
    {
        private const string CadenaConexion =
            @"Server=(localdb)\MSSQLLocalDB;" +
            @"Database=GastosDB;" +
            @"Trusted_Connection=True;" +
            @"TrustServerCertificate=True;";

        public void Insertar(Gasto g)
        {
            using (SqlConnection conexion =
                new SqlConnection(CadenaConexion))
            {
                conexion.Open();

                string sql = "INSERT INTO Gastos " +
                    "(Descripcion, Monto, Categoria) " +
                    "VALUES (@descripcion, @monto, @categoria)";

                using (SqlCommand comando =
                    new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@descripcion", g.Descripcion);
                    comando.Parameters.AddWithValue(
                        "@monto", g.Monto);
                    comando.Parameters.AddWithValue(
                        "@categoria", g.Categoria);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<Gasto> ListarTodos()
        {
            List<Gasto> gastos = new List<Gasto>();

            using (SqlConnection conexion =
                new SqlConnection(CadenaConexion))
            {
                conexion.Open();

                string sql =
                    "SELECT Id, Descripcion, Monto, Categoria " +
                    "FROM Gastos ORDER BY Id";

                using (SqlCommand comando =
                    new SqlCommand(sql, conexion))
                using (SqlDataReader lector =
                    comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        Gasto g = new Gasto
                        {
                            Id = lector.GetInt32(0),
                            Descripcion = lector.GetString(1),
                            Monto = lector.GetDecimal(2),
                            Categoria = lector.GetString(3)
                        };

                        gastos.Add(g);
                    }
                }
            }

            return gastos;
        }
    }
}
