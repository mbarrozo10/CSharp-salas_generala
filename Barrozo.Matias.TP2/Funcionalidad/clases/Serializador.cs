using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Numerics;
using System.Diagnostics;

namespace Funcionalidad.clases
{
    public class Serializazdor<T>
    {
        static string ruta;
        static Serializazdor()
        {
            ruta = @"./Archivos"; //Crea una carpeta
        }

        public static void EscribirJSON(T datos, string archivo)
        {
            string completa = ruta + @"/" + archivo + ".json";

            if (!Directory.Exists(ruta))//Esto significa que la carpeta NO EXISTE
            {
                Directory.CreateDirectory(ruta); //Aca la creamos
            }
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) },
            };
            string objetoJson = "";
            objetoJson += JsonSerializer.Serialize(datos, options);

            File.WriteAllText(completa, objetoJson);


        }

        public static T LeerJSON(string nombre)
        {
            T datos = default;
            string completa = ruta + @"/" + nombre + ".json";

            if (!Directory.Exists(ruta))//Esto significa que la carpeta NO EXISTE
            {
                Directory.CreateDirectory(ruta); //Aca la creamos
            }

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) },
            };

            string archivoJson = File.ReadAllText(completa);
            datos = JsonSerializer.Deserialize<T>(archivoJson, options);

            return datos;

        }




    }
}
