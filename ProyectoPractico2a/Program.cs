using System;
public class MiBiblioteca
{
    struct libreria
    {
        public string tituloLibro;                                                  /* titulo del libro */
        public long ejemplares;                                                     /* ejemplares del libro */
    };
    public static void Main()
    {
        libreria[] libro
        = new libreria[2000];
        long numeroEjemplares = 0;                                                  /* número de libros */
        int i;                                                                      /* i para el bucle */
        int opcion;                                                                 /* opciones para el menú */
        string libroBuscar;                                                         /* opción del menú */
        long ejemplaresBuscar;                                                      /* Para buscar por número de ejemplares */

        do
        {
            /* Menu */
            Console.WriteLine("Bienvenido a biblioteca CENEC");
            Console.WriteLine("Selecciona una opción:");
            Console.WriteLine("1.- Añadir datos de nuevo libro");
            Console.WriteLine("2.- Listar biblioteca");
            Console.WriteLine("3.- Listar libros por unidades");
            Console.WriteLine("4.- Ver más datos de un libro");
            Console.WriteLine("5.- Salir");
            opcion = Convert.ToInt32(Console.ReadLine());


            switch (opcion)
            {                                                            /*  opciones del menú */
                case 1:
                    if (numeroEjemplares < 2000)
                    {
                        Console.WriteLine("Introduce el nombre del libro: ");                                /* añadir un nuevo libro */
                        libro[numeroEjemplares].tituloLibro = Console.ReadLine();
                        Console.WriteLine("Introduce el número de ejemplares: ");                           /* ejemplares que tenemos */
                        libro[numeroEjemplares].ejemplares = Convert.ToInt32(Console.ReadLine());
                        numeroEjemplares++;
                    }
                    else

                        Console.WriteLine("Biblioteca completa");                   /* si hay + de 2000 te avisa de que la biblioteca está completa */
                    break;

                case 2:
                    for (i = 0; i < numeroEjemplares; i++)                                               /* listar biblioteca */
                        Console.WriteLine("Titulo: {0}; Ejemplares {1}",
                        libro[i].tituloLibro, libro[i].ejemplares);
                    break;
                case 3:
                    Console.WriteLine("¿A partir de cuantos ejemplares quieres que te muestre?");       /* listar según las unidades */
                    ejemplaresBuscar = Convert.ToInt64(Console.ReadLine());
                    for (i = 0; i < numeroEjemplares; i++)
                        if (libro[i].ejemplares >= ejemplaresBuscar)
                            Console.WriteLine("Titulo: {0}; Ejemplares: {1} ejemplares",
                            libro[i].tituloLibro, libro[i].ejemplares);
                    break;
                case 4:
                    Console.WriteLine("¿De qué libro quieres ver los ejemplares?");           /* ver datos del libro */
                    libroBuscar = Console.ReadLine();
                    for (i = 0; i < numeroEjemplares; i++)
                        if (libro[i].tituloLibro == libroBuscar)
                            Console.WriteLine("Titulo: {0}; Ejemplares: {1} ejemplares",
                            libro[i].tituloLibro, libro[i].ejemplares);
                    break;
                case 5:
                    Console.WriteLine("Salir del menú");                                        /* salir del menú */
                    break;
                default:
                    Console.WriteLine("Opción desconocida");                                       /* selecciones no válidas */
                    break;
            }
        } while (opcion != 5);                                                                      /* por si se selecciona otra opcion  */

    }
}