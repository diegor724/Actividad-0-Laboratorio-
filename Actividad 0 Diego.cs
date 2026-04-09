
int alumnos = 0;
int computadoras = 0;
string input;
bool valido;

valido = false;
while (valido == false)
{
    Console.WriteLine("ingrese la cantidad de alumnos");
    input = Console.ReadLine();
    if (int.TryParse(input, out alumnos))
    {
        if (alumnos >= 0)
        {
            valido = true;
        }
        else
        {
            Console.WriteLine("Entrada no valida. Ingrese un numero entero");
        }

    }
    else
    {
        Console.WriteLine("entrada no validad. Ingrese un numero entero");
    }
}
valido = false;
while (valido == false)
{
    Console.WriteLine("ingrese la cantidad de computadoras");
    input = Console.ReadLine();
    if (int.TryParse(input, out computadoras))
    {
        if (computadoras >= 0)
        {
            valido = true;
        }
        else
        {
            Console.WriteLine("Entrada no valida. Ingrese un numero entero");
        }

    }
    else
    {
        Console.WriteLine("entrada no validad. Ingrese un numero entero");
    }
}
if (computadoras == 0)
{
    Console.WriteLine(" No se puede dividir por 0");
}
else
{
    double promedio = (double)alumnos / computadoras;

    if (alumnos > computadoras)
    {
        Console.WriteLine("Faltan equipos");
    }
    else
    {
        Console.WriteLine("Equipos suficientes");
    }
    Console.WriteLine("Promedio de alumnos por computadora:" + promedio);
