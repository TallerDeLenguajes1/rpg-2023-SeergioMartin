namespace EspacioPersonaje
{
    public class Personaje
    {
        // Datos
        private string? tipo;
        private string? nombre;
        private string? apodo;
        private DateTime fechaNac;
        private int edad;
        // Caracteristicas
        private float velocidad;
        private float destreza;
        private float fuerza;
        private int nivel;
        private float armadura;
        private float salud;
        // 
        public string? Tipo { get => tipo; set => tipo = value; }
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public int Edad { get => edad; set => edad = value; }
        // 
        public float Velocidad { get => velocidad; set => velocidad = value; }
        public float Destreza { get => destreza; set => destreza = value; }
        public float Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public float Armadura { get => armadura; set => armadura = value; }
        public float Salud { get => salud; set => salud = value; }
        // 
        public void MostrarPersonajes(){
            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            System.Console.WriteLine("+ PERSONAJE: "+Nombre+" | APODO: "+Apodo);
            System.Console.WriteLine("+ TIPO: "+Tipo+" | NIVEL: "+Nivel);
            System.Console.WriteLine("+ EDAD: "+Edad+" | FECHA DE NACIMIENTO: "+FechaNac);
            System.Console.WriteLine("+ CARACTERISTICAS:");
            System.Console.WriteLine("--- VELOCIDAD: "+Velocidad);
            System.Console.WriteLine("--- DESTREZA: "+Destreza);
            System.Console.WriteLine("--- FUERZA: "+Fuerza);
            System.Console.WriteLine("--- ARMADURA: "+Armadura);
            System.Console.WriteLine("--- SALUD: "+Salud);
        }
    }
}