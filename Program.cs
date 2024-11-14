using EJERCICIO_TRABAJO_DE_PROG.___GRUPO_5;
string opcion;
List<Desayuno> desayunos = new List<Desayuno>();

void MostrarMenu()
{
    Console.Clear();
    Console.WriteLine("Menú de Desayunos:\n");
    Console.WriteLine("a) Crear desayuno\n");
    Console.WriteLine("b) Listar desayunos\n");
    Console.WriteLine("c) Eliminar desayuno\n");
    Console.WriteLine("d) Salir\n");
    Console.Write("Selecciona una opción: \n");
}

bool continuarPrograma = true;
while (continuarPrograma)
{
    MostrarMenu();
    opcion = Console.ReadLine().ToLower();

    switch (opcion)
    {
        case "a":
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Creación de Desayuno\n");
                Console.Write("Ingrese el nombre del desayuno: \n");
                string desa = Console.ReadLine();
                Console.Write("\nIngrese el precio del desayuno: \n");
                string precio = Console.ReadLine();
                Console.Write("\nIngrese los días que está disponible el desayuno: \n");
                string dias = Console.ReadLine();

                Desayuno desayuno = new Desayuno
                {
                    Nombre = desa,
                    Precio = precio,
                    Dias = dias
                };
                desayunos.Add(desayuno);

                Console.WriteLine("\nDesayuno agregado exitosamente.\n");
                Console.Write("¿Deseas seguir agregando desayunos? (s/n): ");
                continuar = Console.ReadKey().KeyChar.ToString().ToLower() == "s";
            }
            break;

        case "b":
            Console.Clear();
            Console.WriteLine("Lista de Desayunos:");
            if (desayunos.Count == 0)
            {
                Console.WriteLine("No hay desayunos registrados.\n");
            }
            else
            {
                foreach (var d in desayunos)
                {
                    int diasDisponibles = d.ListaDias().Length;
                    Console.WriteLine($"{d.Nombre} - S/{d.Precio} - Disponible: {diasDisponibles} días");
                }
            }
            Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
            Console.ReadKey();
            break;

        case "c":
            bool eliminar = true;
            while (eliminar)
            {
                Console.Clear();
                Console.Write("Ingrese el nombre del desayuno que desea eliminar: \n");
                string nombreEliminar = Console.ReadLine();
                bool encontrado = false;

                for (int i = 0; i < desayunos.Count; i++)
                {
                    if (desayunos[i].Nombre.Equals(nombreEliminar, StringComparison.OrdinalIgnoreCase))
                    {
                        desayunos.RemoveAt(i);
                        Console.WriteLine("\nDesayuno eliminado exitosamente.\n");
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("\nDesayuno no encontrado.\n");
                }

                Console.Write("¿Deseas seguir eliminando desayunos? (s/n): ");
                eliminar = Console.ReadKey().KeyChar.ToString().ToLower() == "s";
            }
            break;

        case "d":
            Console.WriteLine("\nSaliendo del menú...");
            continuarPrograma = false;
            break;

        default:
            Console.WriteLine("Opción no válida. Intente nuevamente.");
            break;
    }
}

Console.WriteLine("Programa finalizado. Presiona cualquier tecla para cerrar.");
Console.ReadKey();
