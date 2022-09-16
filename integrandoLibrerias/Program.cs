using libreriaSuma;
using LibreriaResta;
using LibreriaMultiplicacion;
using LibreriaDivision;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese el primer numero");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite el número de la operación que desea,asi: suma (1), resta (2), multiplicación (3), división (4)");
int operacion = int.Parse(Console.ReadLine());


if (operacion == 1)
{
    Console.WriteLine("La suma de los 2 numeros es " + Class1.Suma(num1, num2));
}

if  (operacion == 2)
{
    Console.WriteLine("La resta de los 2 numeros es " + ClassResta.Resta(num1, num2));
}

if (operacion == 3)
{
    Console.WriteLine("La multiplicación de los 2 numeros es " + ClassMultiplicacion.Multiplicacion(num1, num2));
}

if (operacion == 4)
{
    Console.WriteLine("La división de los 2 numeros es " + ClassDivision.Division(num1, num2));
}
