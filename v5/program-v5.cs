if (opcio == 5)
{
    if (prestado == true)
    {
        prestado = false;
        Console.WriteLine("El libro ha sido devuelto y ahora está disponible.");
    }
    else
    {
        Console.WriteLine("El libro ya estaba disponible.");
    }
}
