# RepositorioGastos

Programa de consola en C# para registrar y listar gastos utilizando SQL Server, ADO.NET y consultas parametrizadas.

## Requisitos

- Visual Studio Community 2026.
- .NET 10.
- SQL Server LocalDB.
- Base de datos `GastosDB` y tabla `Gastos` de la Clase 10.

## Cómo ejecutar

1. Abrir `RepositorioGastos` en Visual Studio.
2. Verificar que la base de datos `GastosDB` esté disponible.
3. Ejecutar con `Ctrl + F5`.
4. Seleccionar una opción del menú:
   - **1. Registrar gasto:** solicita descripción, monto y categoría.
   - **2. Listar gastos:** muestra los registros y calcula el total.
   - **3. Salir:** finaliza el programa.

## Funcionamiento

La clase `Gasto` representa cada registro. `GastoRepositorio` contiene los métodos `Insertar()` y `ListarTodos()`, que utilizan consultas parametrizadas para trabajar con SQL Server. El programa valida los datos ingresados y muestra el total de los gastos registrados.

## Video explicativo

**Enlace público:https://drive.google.com/file/d/15e6tEPHQVN8ZF-1cX9t2DWluJViYumiU/view?usp=sharing