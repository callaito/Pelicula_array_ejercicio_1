// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string[] pelicula = new string[3];
string[] categoria = new string[3];

for (int i = 0; i < pelicula.Length; i++)
{
    Console.WriteLine("Introduzca las peliculas: {0}"+(i+1));
    Console.WriteLine();
    pelicula[i] = Console.ReadLine();

    Console.WriteLine("Introduzca las categoria: {0}"+(i+1));
    categoria[i] = Console.ReadLine();


    
}

for (int i = 0; i < pelicula.Length; i++)
{ Console.WriteLine("Pelicula: {0} , Categoria  {1}" , pelicula[i], categoria[i]);
}
