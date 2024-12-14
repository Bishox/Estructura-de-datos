using System;

class Program
{
    static void Main()
    {
        // Menú para seleccionar la figura geométrica
        int opcion = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("Seleccione una figura geométrica para calcular su área y perímetro:");
            Console.WriteLine("1. Pentágono");
            Console.WriteLine("2. Hexágono");
            Console.WriteLine("3. Salir");
            Console.Write("Opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    // Ingreso de datos para el Pentágono
                    Console.Write("\nIngrese el valor del lado del Pentágono: ");
                    double ladoPentagono = Convert.ToDouble(Console.ReadLine());

                    // Crear una instancia de Pentágono con el valor del lado ingresado
                    Pentagono miPentagono = new Pentagono(ladoPentagono);

                    // Mostrar área y perímetro del pentágono
                    Console.WriteLine("\nPentágono:");
                    Console.WriteLine($"Área: {miPentagono.CalcularArea():F2}"); // Muestra el área con 2 decimales
                    Console.WriteLine($"Perímetro: {miPentagono.CalcularPerimetro():F2}"); // Muestra el perímetro con 2 decimales
                    break;

                case 2:
                    // Ingreso de datos para el Hexágono
                    Console.Write("\nIngrese el valor del lado del Hexágono: ");
                    double ladoHexagono = Convert.ToDouble(Console.ReadLine());

                    // Crear una instancia de Hexágono con el valor del lado ingresado
                    Hexagono miHexagono = new Hexagono(ladoHexagono);

                    // Mostrar área y perímetro del hexágono
                    Console.WriteLine("\nHexágono:");
                    Console.WriteLine($"Área: {miHexagono.CalcularArea():F2}"); // Muestra el área con 2 decimales
                    Console.WriteLine($"Perímetro: {miHexagono.CalcularPerimetro():F2}"); // Muestra el perímetro con 2 decimales
                    break;

                case 3:
                    Console.WriteLine("\nSaliendo del programa...");
                    break;

                default:
                    Console.WriteLine("\nOpción no válida. Intente de nuevo.");
                    break;
            }

            // Pausa antes de volver a mostrar el menú
            if (opcion != 3)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 3);
    }
}
