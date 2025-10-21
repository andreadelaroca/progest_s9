using System;

class Program
{
    public static Stack<string> acciones = new Stack<string>();
    static void Main()
    {
        Console.WriteLine("-----Menú de acciones-----");
        Console.WriteLine("1. Agregar acción");
        Console.WriteLine("2. Visualizar última acción");
        Console.WriteLine("3. Deshacer última acción");
        Console.WriteLine("4. Salir");
        Console.Write("Elija una opción: ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                AgregarAccion();
                break;

            case 2:
                VisualizarAccion();
                break;

            case 3:
                DeshacerAccion();
                break;

            case 4:
                break;

            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }
    static void AgregarAccion()
    {
        Console.Write("Introduzca la acción: ");
        acciones.Push(Console.ReadLine()!);
    }
    static void VisualizarAccion()
    {

    }
    static void DeshacerAccion()
    {

    }
}