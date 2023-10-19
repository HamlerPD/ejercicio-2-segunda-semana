// Confeccionar un programa que permita cargar un número entero positivo de hasta tres cifras y
// muestre un mensaje indicando si tiene 1, 2, o 3 cifras. Mostrar un mensaje de error si el número de cifras es mayor.


using System.Runtime.CompilerServices;

int num = 0;

string linea = string.Empty;

Console.WriteLine("ingrese un numero ");
linea = Console.ReadLine();
num = Convert.ToInt32(linea);


if (num > 99 && num <= 999)
{
    Console.WriteLine(" El numero es de tres cifras");
}
else
{
    if(num > 9 && num <= 99)
        Console.WriteLine(" El numero es de dos cifras");
    else
    {
        if (num > 0 && num <= 9)
            Console.WriteLine(" el numero es de una cifra");
        else
        {
            Console.WriteLine(" el numero es mayor de 3 cifras");
        }
    }
}  Console.ReadKey();
