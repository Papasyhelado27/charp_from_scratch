
namespace Helloword
{
    class Program{
       
     static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ DE EJERCICIOS =====");
            Console.WriteLine("1. Positive Power");
            Console.WriteLine("2. Double or Triple");
            Console.WriteLine("3. Root or Square");
            Console.WriteLine("4. Circle Perimeter");
            Console.WriteLine("5. Midweek Day");
            Console.WriteLine("6. Tax Calculator");
            Console.WriteLine("7. Remainder Finder");
            Console.WriteLine("8. Sum of Evens");
            Console.WriteLine("9. Fraction Difference");
            Console.WriteLine("10. String Length");
            Console.WriteLine("11. Average of Four");
            Console.WriteLine("12. Smallest of Five");
            Console.WriteLine("13. Vowel Counter");
            Console.WriteLine("14. Factorial Finder");
            Console.WriteLine("15. InRange Validator");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            Console.WriteLine();

 switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese un número: ");
                    int num1 = int.Parse(Console.ReadLine());
                    if (num1 > 0)
                        Console.WriteLine(num1 * num1);
                    else if (num1 == 0)
                        Console.WriteLine(0);
                    else
                        Console.WriteLine("Número negativo.");
                    break;

                case 2:
                    Console.Write("Ingrese el primer número: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    int b = int.Parse(Console.ReadLine());

                    if (a >= b)
                        Console.WriteLine(a * 2);
                    else
                        Console.WriteLine(b * 3);
                    break;
 case 3:
                    Console.Write("Ingrese un número: ");
                    double num3 = double.Parse(Console.ReadLine());
                    if (num3 >= 0)
                        Console.WriteLine(Math.Sqrt(num3));
                    else
                        Console.WriteLine(num3 * num3);
                    break;

                case 4:
                    Console.Write("Ingrese el radio: ");
                    double r = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Round(2 * Math.PI * r, 2));
                    break;

                     case 5:
                    Console.Write("Ingrese un número (1-7): ");
                    int dia = int.Parse(Console.ReadLine());
                    switch (dia)
                    {
                        case 1: Console.WriteLine("Lunes"); break;
                        case 2: Console.WriteLine("Martes"); break;
                        case 3: Console.WriteLine("Miércoles"); break;
                        case 4: Console.WriteLine("Jueves"); break;
                        case 5: Console.WriteLine("Viernes"); break;
                        default: Console.WriteLine("Número fuera del rango laboral."); break;
                    }
                    break;

                case 6:
                    Console.Write("Ingrese salario anual: ");
                    double salario = double.Parse(Console.ReadLine());
                    if (salario > 12000)
                        Console.WriteLine((salario - 12000) * 0.15);
                    else
                        Console.WriteLine("No debe impuestos.");
                    break;
}
    }
}

}
