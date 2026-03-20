// Registro de Prestamo:
//Se solicitan datos del prestamo, nombre del usuario y el libro que quiere
Console.WriteLine("Ingrese el nombre del usuario: ");
string usuario = Console.ReadLine();

Console.WriteLine("Ingrese el título del libro a prestar: ");
string tituloPrestamo = Console.ReadLine();

string tlib = "";                 // variable en la que se registró el libro (inciso 1)
bool estaPrestado = false;        //Estado inicial del libro (disponible)
//Comparar los titulos del libro. Evitando diferencias en mayúsculas 
if (tituloPrestamo.ToUpper() == tlib.ToUpper())
{
    //Verificación de disponibilidad del libro 
    if (estaPrestado == false)
    {
        estaPrestado = true;
        Console.WriteLine("Registrando préstamo a: " + usuario);
    }
    else
    {
        Console.WriteLine("El libro no se encuentra disponible, ya está prestado.");
    }
}
else
{
    Console.WriteLine("Libro no encontrado.");
}


    

