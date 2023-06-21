using System.Text.Json;
using System.Text.Json.Serialization;
namespace EspacioPersonaje{
    public class PersonajesJson
    {
        public void GuardarPersonajes(List<Personaje> lista, string archivo){
            string json;
            json = JsonSerializer.Serialize(lista);
            File.WriteAllText(archivo+".json",json);
        }
        public List<Personaje>? LeerPersonajes(string archivo){
            List<Personaje>? listaPersonajesJson = null;
            if (Existe(archivo))
            {
                string json = File.ReadAllText(archivo);
                listaPersonajesJson = JsonSerializer.Deserialize<List<Personaje>>(json);
            }
            return listaPersonajesJson;
        }
        public bool Existe(string archivo){
            return (File.Exists(archivo));
        }
    }
}