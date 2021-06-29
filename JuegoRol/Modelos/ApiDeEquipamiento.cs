using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Net;

namespace JuegoRol.Modelos
{
    class ApiDeEquipamiento
    {
        public List<Equipment> ListadoDeEquipamiento { get; set; }


        public ApiDeEquipamiento()
        {
            ListadoDeEquipamiento = GetEquipment();
        }

        public static List<Equipment> GetEquipment()
        {
            var url = "https://www.dnd5eapi.co/api/equipment-categories/weapon";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream streamReader = response.GetResponseStream())
                    {
                        if (streamReader != null)
                        {
                            using (StreamReader ObjReader = new StreamReader(streamReader))
                            {
                                string responseBody = ObjReader.ReadToEnd();
                                Armas equipacion = JsonSerializer.Deserialize<Armas>(responseBody);
                                return equipacion.Equipment;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return null;
        }
    }
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Equipment
    {
        [JsonPropertyName("index")]
        public string Index { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Armas
    {
        [JsonPropertyName("index")]
        public string Index { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("equipment")]
        public List<Equipment> Equipment { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}


