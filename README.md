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

## Evidencias

### Escenario 1: Listar gastos iniciales
![Escenario 1](evidencias/escenario1.png)

### Escenario 2: Registrar Café por Q12.00
![Escenario 2](evidencias/escenario2.png)

### Escenario 3: Validar montos inválidos
![Escenario 3](evidencias/escenario3.png)

### Escenario 4: Registrar Tacos 'al pastor' por Q35.00
![Escenario 4](evidencias/escenario4.png)

## Video explicativo

**Enlace público:** PENDIENTE DE AGREGAR