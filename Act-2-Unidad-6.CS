using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Ruta del archivo binario
        string filePath = "ruta_del_archivo.bin";

        try
        {
            // Leemos el archivo binario
            byte[] fileBytes = File.ReadAllBytes(filePath);

            // Mostramos el contenido del archivo
            Console.WriteLine("Contenido del archivo:");
            for (int i = 0; i < fileBytes.Length; i++)
            {
                Console.Write(fileBytes[i].ToString("X2") + " "); // Mostramos los bytes en formato hexadecimal
                if ((i + 1) % 16 == 0) // Cada 16 bytes hacemos un salto de línea para mejorar la legibilidad
                {
                    Console.WriteLine();
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"El archivo {filePath} no existe.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error al leer el archivo {filePath}: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ha ocurrido un error inesperado: {ex.Message}");
        }
    }
}

