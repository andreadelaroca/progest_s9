using System;

class Program
{
    public static Stack<string> acciones = new Stack<string>();
    static void Main()
    {
  
        while (true)
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
                    return;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        } 
    }
    static void AgregarAccion()
    {
        Console.Write("Introduzca la acción: ");
        acciones.Push(Console.ReadLine()!);
    }
    static void VisualizarAccion()
    {
        if (acciones.Count == 0)
        {
            Console.WriteLine("No hay acciones registradas");
        }
        else
        {
            Console.WriteLine($"La última acción fue: {acciones.Peek()}");
        }
    }
    static void DeshacerAccion()
    {
        if (acciones.Count == 0)
        {
            Console.WriteLine("No hay acciones registradas");
        }
        else
        {
            Console.WriteLine($"La acción {acciones.Peek()} será desecha.");
            acciones.Pop();
        }
    }
}