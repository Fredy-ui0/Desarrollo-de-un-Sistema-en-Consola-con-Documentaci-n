string tlib = " ";
string aut = " ";
int añ = 0;
int cat = 0;
string opca = " ";
int opcio = 0;

while (opcio != 6)
{

    Console.WriteLine("1 Registrar libro ");
    Console.WriteLine("2 Mostrar libros registrados");
    Console.WriteLine("3 Buscar libro por título ");
    Console.WriteLine("4 Registrar préstamo de libro");
    Console.WriteLine("5 Devolver libro");
    Console.WriteLine("6 Salir ");
    Console.Write("coloque la opcion elegida: ");
    opcio = int.Parse(Console.ReadLine());

    if (opcio == 1)
    {

        Console.Write("coloque el titulo del libro: ");
        tlib = Console.ReadLine();

        Console.Write("coloque el nombre del autor: ");
        aut = Console.ReadLine();


        Console.WriteLine("1 Ciencia ");
        Console.WriteLine("2 Literatura");
        Console.WriteLine("3 Tecnología");
        Console.WriteLine("4 Historia ");


        Console.Write("escoja una categoria:");
        cat = int.Parse(Console.ReadLine());

        switch (cat)
        {
            case 1:
                Console.WriteLine("ciencia ");
                opca = Console.ReadLine();
                break;
            case 2:
                Console.WriteLine("literatura");
                opca = Console.ReadLine();
                break;

            case 3:
                Console.WriteLine("tecnologia");
                opca = Console.ReadLine();
                break;

            case 4:
                Console.WriteLine("historia");
                opca = Console.ReadLine();
                break;
            default:
                Console.WriteLine("opcion invalida");
                break;
        }

    }

}
