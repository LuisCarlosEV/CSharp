using System.Linq;

namespace Programando.Csharp.ejercicios.consolapp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Clear();
			ConsultasBasicas();
		}
	
		static void ConsultasBasicas()
		{
			// T-SQL: SELECT *From dbo.ListaProductos

			// Métodos de LINQ
			var r1a = DataLists.ListaProductos
			.Select(r => r);

			// Expresion LINQ
			var r1b = from r in DataLists.ListaProductos
					  select r;

			foreach(Producto item in r1a) Console.WriteLine($"{item.Id} {item.Descripcion}");
			Console.WriteLine(Environment.NewLine);

			// T-SQL: SELECT Nombre *From dbo.ListaClientes

			// Métodos de LINQ
			var r2a = DataLists.ListaClientes
			.Select(r => r.Nombre);

			// Expresion LINQ
			var r2b = from r in DataLists.ListaClientes
					  select r.Nombre;

			foreach (string item in r2b) Console.WriteLine($"{item}"); 
			Console.WriteLine(Environment.NewLine);

			// T-SQL: SELECT Id, Nombre *From dbo.ListaClientes

			// Métodos de LINQ

			var r3a = DataLists.ListaClientes
			.Select(r => new { r.Id, r.Nombre });

			// Expresion LINQ
			var r3b = from r in DataLists.ListaClientes
					  select new { r.Id, r.Nombre };

			foreach (var item in r3b) Console.WriteLine($"{item.Id} {item.Nombre}");
			Console.WriteLine(Environment.NewLine);

			// T-SQL: SELECT Id AS Code, Nombre AS NombreCompleto *From dbo.ListaClientes
			var r3c = DataLists.ListaClientes
			.Select(r => new { Code = r.Id, NombreCompleto = r.Nombre });

			foreach (var item in r3c) Console.WriteLine($"{item.Code} {item.NombreCompleto}");
			Console.WriteLine(Environment.NewLine);

			// T-SQL: SELECT Descripción FROM db.ListaProductos WHERE precio < 0.90

			// Métodos de LINQ
			var r4a = DataLists.ListaProductos
				.Where(r => r.Precio < 0.90)
				.Select(r => r.Descripcion);
			// Expresion LINQ
			var r4b = from r in DataLists.ListaProductos
					  where r.Precio <	0.90
					  select r.Descripcion;
			foreach (var item in r4b) Console.WriteLine($"{item}");
			Console.WriteLine(Environment.NewLine);

			// T-SQL: SELECT Descripción FROM db.ListaProductos WHERE precio < 0.90 ORDER By Descripción (alfabeticamente)

			// Métodos de LINQ
			var r5a = DataLists.ListaProductos				//Ordenando en db
				.Where(r => r.Precio < 0.90)
				.OrderBy(r => r.Descripcion)
				.Select(r => r.Descripcion);

			var r5aa = DataLists.ListaProductos             //Ordenando en db
			.Where(r => r.Precio < 0.90)
			.OrderByDescending(r => r.Descripcion)
			.Select(r => r.Descripcion);

			var r5aaa = DataLists.ListaProductos				//Ordenando en PC
			.Where(r => r.Precio < 0.90)
			.Select(r => r.Descripcion)
			.OrderBy(r => r);					// r es un string entonces no es necesario especificar "Descripción"

			// Expresion LINQ
			var r5b = from r in DataLists.ListaProductos
					  where r.Precio < 0.90
					  orderby r.Descripcion
					  select r.Descripcion;

			var r5bb = from r in DataLists.ListaProductos
					  where r.Precio < 0.90
					  orderby r.Descripcion descending
					  select r.Descripcion;

			var r5bbb = from r in DataLists.ListaProductos
					   where r.Precio < 0.90
					   select r.Descripcion.ToList().OrderBy(r =>r);

			foreach (var item in r5b) Console.WriteLine($"{item}");
			Console.WriteLine(Environment.NewLine);

			// Otros Ejemplos
			// Constains -> Contine; StarsWith -> Comienza; EndsWith -> Finaliza

			var r6a = DataLists.ListaProductos
				.Where(r => r.Descripcion.ToLower().EndsWith("boli"))
				.Select(r => r);

			var r6b = from r in DataLists.ListaProductos
					  where r.Descripcion.ToLower().Contains("boli")
					  select r;

			// Count -> Cuenta los elementos
			// Distinct -> Valor distinto
			// Max -> Valor maximo
			// Min -> valor minimo
			// Sum -> Suma de valores
			// Average -> media de los valores
			// Aggregate -> Aplicar formula o metodo de agregacion

			var r7a = DataLists.ListaProductos
				.Where(r => r.Precio < 0.90)
				.Count();

			var r7b = DataLists.ListaProductos
				.Count(r => r.Precio < 0.90);

			var r7c = (from r in DataLists.ListaProductos
					   where r.Precio < 0.90
					   select r.Descripcion).Count();

		}
	}
}