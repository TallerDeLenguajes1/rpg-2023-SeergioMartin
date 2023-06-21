// See https://aka.ms/new-console-template for more information
using EspacioPersonaje;

List<Personaje>? listaPersonajes = new List<Personaje>();
PersonajesJson archivo = new PersonajesJson();

if (!(archivo.Existe("Personajes.json")))
{
    for (int i = 0; i < 10; i++)
    {
        FabricaDePersonajes personajes = new FabricaDePersonajes();
        listaPersonajes.Add(personajes.CrearPersonaje());
    }
    archivo.GuardarPersonajes(listaPersonajes,"Personajes");
}
listaPersonajes = archivo.LeerPersonajes("Personajes.json");

foreach (var personajes in listaPersonajes)
{
    personajes.MostrarPersonajes();
}