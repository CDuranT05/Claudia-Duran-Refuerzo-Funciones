// See https://aka.ms/new-console-template for more information


Dictionary<string, int> inventario = new Dictionary<string, int>()
{
    {"Franela", 5 },
    {"Pantalon", 4 },
    {"Gorra", 3 },
    {"Medias", 5 }
};

bool inv = true;
while (inv)
{
    Console.WriteLine("Bienvenido al inventario, por favor elige una opcion: ");
    Console.WriteLine("1:Agregar Producto / 2:Eliminar / 3:Actualizar cantidad / 4:Mostrar inventario / 5:Salir");
    string usuario = Console.ReadLine();

    switch (usuario)
    {   
        case "1":
            Console.WriteLine("Por favor ingresa el nombre del nuevo producto: ");
            string producto =Console.ReadLine();
            Console.WriteLine("Por favor ingresa el numero de la cantidad producto en stock: ");
            int numero =int.Parse(Console.ReadLine());
            inventario.Add(producto,numero);
            Console.WriteLine("El producto se ha agregado con exito");
            break;
        case "2":
            Console.WriteLine("Por favor ingresa el nombre del producto a eliminar: ");
            string elimina = Console.ReadLine();
            inventario.Remove(elimina);
            Console.WriteLine("El producto se ha eliminado con exito");
            break;
        case "3":
            int suma = 0;
            foreach (int valor in inventario.Values)
            {
                suma += valor;
            }
            Console.WriteLine("La suma de todos los productos total es: " + suma);
            break;
        case "4":

            Console.WriteLine("Los productos dentro del inventario son: ");
            foreach(var i in inventario)
            {
                Console.WriteLine($"Producto: {i.Key} - Cantidad: {i.Value}");
            }
            break;
        case "5":
            inv = false;
            break;
        default:
            Console.WriteLine("Lo sentimos, esta opcion no esta disponible");
            break;
    }
    

}

