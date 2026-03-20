string[] libros = { "Cien años de soledad", "El principito", "Don Quijote", "La sombra del viento" };

        Console.Write("Ingrese el título del libro que desea buscar: ");
        string tituloBuscado = Console.ReadLine();

bool encontrado = false;

foreach (string libro in libros)
{
// evitar problemas de mayúsculas/minúsculas o espacios
    if (libro.ToLower().Trim() == tituloBuscado.ToLower().Trim())
    {
        encontrado = true;
        break;
    }
}
if (encontrado)
{
    Console.WriteLine("El libro existe en el sistema.");
}
else
{
    Console.WriteLine("El libro no está registrado.");
}
