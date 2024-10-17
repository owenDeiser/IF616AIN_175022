using System;

class Calculadora
{
    static void Main()
    {
        Console.WriteLine("Calculadora Básica en C#");

        Console.Write("Introduce el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Selecciona una operación: ");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");

        int opcion = Convert.ToInt32(Console.ReadLine());

        double resultado = 0;

        switch (opcion)
        {
            case 1:
                resultado = num1 + num2;
                Console.WriteLine($"El resultado de la suma es: {resultado}");
                break;
            case 2:
                resultado = num1 - num2;
                Console.WriteLine($"El resultado de la resta es: {resultado}");
                break;
            case 3:
                resultado = num1 * num2;
                Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                break;
            case 4:
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"El resultado de la división es: {resultado}");
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir por cero.");
                }
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}

