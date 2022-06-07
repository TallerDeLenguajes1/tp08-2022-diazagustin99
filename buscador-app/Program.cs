// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
var ListaDeArchivos = new List<string>();
Console.WriteLine("Hello, World!");
System.Console.WriteLine("Ingrese el path que desea enumerar: ");
string path = Console.ReadLine();
string DirecArchivo = @"C:\Users\Alumno\Desktop\tp8diaz\tp08-2022-diazagustin99\buscador-app\index.csv";
ListaDeArchivos.Add("Orden;Nombre;Extension");
if (Directory.Exists(path))
{
    var Archivos = Directory.GetFiles(path);

    for (int i = 0; i < Archivos.Count(); i++)
    {
        ListaDeArchivos.Add(i + ";" + Path.GetFileNameWithoutExtension(Archivos[i]) + ";" + Path.GetExtension(Archivos[i]));
    }

    foreach (var item in ListaDeArchivos)
    {
        System.Console.WriteLine(item.ToString());
    }
File.WriteAllLines(DirecArchivo, ListaDeArchivos);

}else
{
    System.Console.WriteLine("La ruta especificada no existe.");
}

