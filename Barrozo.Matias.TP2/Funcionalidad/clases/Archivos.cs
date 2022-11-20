using System;
using System.IO;

namespace BibliotecaDeClases
{
    public static class Archivo
    {
        public static string Leer(string archivo, string ruta)
        {
            string rutaCompleta;
            string datos = string.Empty;
            if (Directory.Exists(ruta))
            {
                rutaCompleta = BuscarArchivo(ruta, archivo);
                if (rutaCompleta != null)
                {
                    using (StreamReader sr = new StreamReader(rutaCompleta))
                    {
                        string line;

                        line = sr.ReadToEnd();

                        datos += line;
                    }
                }
                else
                {
                    throw new Exception("No se encontró el archivo solicitado");
                }

            }
            return datos;

        }
        private static string BuscarArchivo(string ruta, string nombreArchivo)
        {
            string[] archivos = Directory.GetFiles(ruta); 

            foreach (string item in archivos)
            {
                if (item.Contains(nombreArchivo))
                {
                    return item;
                }
            }
            return null;
        }


        public static bool Escribir(string mensaje, string nombreArchivo)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string completa = ruta + @$"/{nombreArchivo}" + ".txt";
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                using (StreamWriter sw = new StreamWriter(completa))
                {
                    sw.WriteLine(mensaje);
                }
                return true;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
            return false;


        }

    }
}
