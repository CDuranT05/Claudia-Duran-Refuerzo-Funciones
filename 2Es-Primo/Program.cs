// See https://aka.ms/new-console-template for more information


bool EsPrimo(int numero)
{
    bool primo = true;
    if(numero % 2 == 0)
    {
        primo = false;
    }
    return primo;
}

Console.WriteLine("Por favor ingrese el numero desde el cual desee iniciar el rango");
int inicio = int.Parse(Console.ReadLine());
Console.WriteLine("Por favor ingrese el numero desde el cual desee finalizar el rango");
int fin = int.Parse(Console.ReadLine());


List<int> Primos = new List<int>();
for(int i= inicio; i <= fin; i++)
{
    if (EsPrimo(i)) {
        Primos.Add(i);
    }
}

foreach (int i in Primos)
{
    Console.WriteLine("Los numeros primos en la lista son: " + i);
}
