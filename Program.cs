using EJERCICIO_TRABAJO_DE_PROG.___GRUPO_5;
 string opcion;
List<Desayuno> desayunos = new List<Desayuno>();
do {
   
    string desa, dias, precio;

    Console.WriteLine("Menú de Desayunos: \n");
    Console.WriteLine("a) Crear desayuno\n");
    Console.WriteLine("b) Listar desayunos\n");
    Console.WriteLine("c) Eliminar desayuno\n");
    Console.WriteLine("d) Salir\n");
    Console.Write("Selecciona una opción: \n");
    opcion = Console.ReadLine().ToLower();
    
    
    switch (opcion) {
        case "a":   
    Console.WriteLine("\nIngrese el nombre del desayuno: ");
    desa = Console.ReadLine().ToLower();
    Console.WriteLine("\nIngrese el precio del desayuno: ");
    precio = Console.ReadLine().ToLower();
    Console.WriteLine("\nIngrese los dias que esta disponible el desayuno: ");
    dias = Console.ReadLine().ToLower();

            Desayuno desayuno = new Desayuno()
            {
                Nombre = desa,
                Precio = precio,
                Dias = dias
            };
            desayunos.Add(desayuno);
            Console.WriteLine("\nDesayuno agregado exitosamente\n");
            break;

        case "b":
            Console.WriteLine("\nLista de Desayunos:");
            if (desayunos.Count == 0)
            {
                Console.WriteLine("No hay desayunos registrados.\n");
            }
            else
            {
                foreach (var d in desayunos)
                {
                    int diasDisponibles = d.ListaDias().Length;
                    Console.WriteLine($"{d.Nombre} S/{d.Precio} Disponible: {diasDisponibles} días\n");
                }
                Console.WriteLine();
            }
            break;

        case "c":
            Console.Write("\nIngrese el nombre del desayuno que desea eliminar: ");
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
            break;

        case "d":
            Console.WriteLine("\nSaliendo del menú...");
            break;

        default:
            Console.WriteLine("Opción no válida. Intente nuevamente.\n");
            break;
    }
} while (opcion!="d");

Console.ReadKey();