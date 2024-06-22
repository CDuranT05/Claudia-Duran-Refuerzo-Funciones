// See https://aka.ms/new-console-template for more information

string LanzarDados()
{
    Random random = new Random();
    int resultados = random.Next(0,7);
    string Dados= resultados.ToString();
    return Dados;
}



bool jugar = true;

while (jugar)
{
    Console.WriteLine("Quieres Lanzar los Dados?");
    Console.WriteLine("L:para lanzar / S:salir");
    string usuario = Console.ReadLine();

    if (usuario == "L")
    {
        
        Console.WriteLine(value:"el primer resultado del lanzamiento es: " + LanzarDados());
        Console.WriteLine(value: "el segundo resultado del lanzamiento es: " + LanzarDados());
        Console.WriteLine("Quieres volver a lanzar? pulsa L");
        usuario = Console.ReadLine();
        while (jugar)
        {
            if (usuario == "L") {
                Console.WriteLine(value: "el primer resultado del lanzamiento es: " + LanzarDados());
                Console.WriteLine(value: "el segundo resultado del lanzamiento es: " + LanzarDados());
            }
            else
            {
                jugar = false;
                break;
            }
        }

    }
    else if(usuario == "S")
    {
        jugar = false; break;
    }
}