// Registro de Prestamo
string tlib = "Clean Code";
bool estaPrestado = false;

Console.WriteLine("--- Módulo de Préstamos ---");
Console.Write("Usuario: ");
string usuario = Console.ReadLine();
Console.Write("Libro a prestar: ");
string tituloPrestamo = Console.ReadLine();

if (tituloPrestamo.ToUpper() == tlib.ToUpper())
{
    if (!estaPrestado)
    {
        estaPrestado = true;
        Console.WriteLine("Préstamo exitoso a: " + usuario);
    }
    else
    {
        Console.WriteLine("El libro ya está prestado.");
    }
}
else
{
    Console.WriteLine("Libro no encontrado.");
}
