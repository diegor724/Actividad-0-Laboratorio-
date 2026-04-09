

int personas = 0;
int bebidad = 0;
string input;
bool valido;

valido  = false;
while (valido == false)
{
    Console.WriteLine(" Ingrese la cantidad de personas que habra en esta fiesta");
    input = Console.ReadLine();
    if (int.TryParse(input, out personas))
    {
        if (personas >= 0)
            valido = true
                }
    else
    { Console.WriteLine("Error ingrese un valor entero");
    }
}else
{
    Console.WriteLine("Error ingrese un valor entero");
}