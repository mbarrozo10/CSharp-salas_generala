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
                if(rutaCompleta!=null)
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
            return datos ;

        }
        private static string BuscarArchivo(string ruta, string nombreArchivo)
        {
            string[] archivos = Directory.GetFiles(ruta); //Trae todas las rutas de los archivos

            foreach (string item in archivos)
            {
                if (item.Contains(nombreArchivo))
                {
                    return item;
                }
            }
            return null;
        }

    }
}
