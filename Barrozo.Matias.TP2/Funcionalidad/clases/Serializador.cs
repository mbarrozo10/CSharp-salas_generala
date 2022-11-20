using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace Funcionalidad.clases
{
    public static class Serializador<T>
    {
        static string ruta;
        static Serializador()
        {
            ruta = @"./Archivos"; 
        }

        public static void EscribirJSON(T datos, string archivo) 
        {
            string completa = ruta + @"/" + archivo + ".json";
            if (archivo != null && datos != null)
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) },
                };
                string objetoJson = "";
                objetoJson += JsonSerializer.Serialize(datos, options);

                File.WriteAllText(completa, objetoJson);
            }
            else
            {
                throw new NullReferenceException();
            }

        }

        public static T LeerJSON(string nombre)
        {
            T? datos = default;
            string completa = ruta + @"/" + nombre + ".json";

            try
            {
                if (nombre != null && nombre!= String.Empty)
                {

                    if (!Directory.Exists(ruta))
                    {
                        Directory.CreateDirectory(ruta);
                    }

                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) },
                    };

                    string archivoJson = File.ReadAllText(completa);
                    datos = JsonSerializer.Deserialize<T>(archivoJson, options);
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            catch (Exception)
            {
                throw;
            }
            
            return datos;
        }
    }
}
