namespace EspacioPersonaje{
    public class FabricaDePersonajes{
        public string[] Nombres = {
            // Guerreros
            "King Arthur","Thorfinn Karlsefni","Aragorn","Thor","Askeladd","Leonidas","Kratos","Perseo","Levi Ackerman","Lancelot",
            // Magos
            "Gandalf","Sauron","Merlin","Doctor Strange","Voldemort","Shang Tsung","Morgana","Albus Dumbledore","Harry Potter","Sabio Oscuro",
            // Arqueros
            "Legolas","Hawkeye","Bardo I","Uryu Ishida","Green Arrow","Katnis Everdeen","Robin Hood","Susan Pevensie","Tauriel","Atreus",
            // Cazadores
            "Tanjiro Kamado","Zenitsu Agatsuma","Giyu Tomioka","Kyojuro Rengoku","Shinobu Kocho","Ichigo Kurosaki","Gon Freecss","Guts","Blade","Van Helsing",
            // Demonios
            "Muzan Kibutsuji","Akaza","Gyuutarou","Azazel","Astaroth","Lucifer","Lilith","Leviathan","Beelzebub","Susamaru",
            // Criaturas
            "Gollum","Fenrir","Griffin","Chimera","Centaur","Phoenix","Pegasus","Gorgon","Cerberus","Medusa"
        };
        public string[] Tipos = {
            "Guerrero","Mago","Arquero","Cazador","Demonio","Criatura"
        };
        public string[] Apodos = {
            // Guerreros
            "El Destructor","El Indomable","El Filo Mortal","El Lobo de Guerra","El Azote","El Implacable","El Despiadado","El Señor de la Guerra","El Martillo de Hierro","El Guerrero de la Oscuridad",
            // Magos
            "El Hechicero","El Brujo Astral","El Oráculo","El Vidente de las Sombras","El Maestro de los Elementos","El Hechicero Supremo","El Encantador","El Mago Estelar","El Guardián de los Secretos","El Invocador",
            // Arqueros
            "El Ojo de Águila","El Francotirador","El Maestro del Arco","El Disparo Preciso","El Acechador Silencioso","El Arquero Veloz","El Arquero Mortal","El Lanzador de Flechas","El Vigía de los Bosques","El Verdugo con Arco",
            // Cazadores
            "El Rastreador","El Acechador","El Cazador Silencioso","El Maestro de la Presa","El Buscador de Trofeos","El Verdugo de Bestias","El Rastreador de Sombras","El Asesino Furtivo","El Vigía de la Naturaleza","El Devorador de Presas",
            // Demonios
            "El Devorador de Almas","El Desgarrador de Espíritus","El Lamento de la Oscuridad","El Portador de Tormentas","El Señor de las Sombras","El Destructor de Mundos","El Conquistador de Reinos","El Devastador Infernal","El Seraphim Oscuro","El Devorador de Universos",
            // Criaturas
            "El Errante Dimensional","El Ser de Mil Ojos","El Rugido de las Profundidades","El Señor de las Bestias","El Guardián de los Bosques","El Espíritu Errante","El Coloso de Piedra","El Vigía de las Cavernas","El Guardián de los Portales","El Embajador de la Oscuridad",
        };

        public Personaje CrearPersonaje(){
            Personaje personaje = new Personaje();
            Random aleatorio = new Random();
            personaje.Tipo = Tipos[aleatorio.Next(0,6)];
            personaje.Salud = (float)100;
            switch (personaje.Tipo){
            case "Guerrero":
                personaje.Nombre = Nombres[aleatorio.Next(0,10)];
                personaje.Apodo = Apodos[aleatorio.Next(0,10)];
                personaje.Velocidad = (float)aleatorio.Next(1,11);
                personaje.Destreza = (float)aleatorio.Next(1,6);
                personaje.Fuerza = (float)aleatorio.Next(1,11);
                personaje.Armadura = (float)aleatorio.Next(1,11);
                break;
            case "Mago":
                personaje.Nombre = Nombres[aleatorio.Next(10,21)];
                personaje.Apodo = Apodos[aleatorio.Next(10,21)];
                personaje.Velocidad = (float)aleatorio.Next(1,11);
                personaje.Destreza = (float)aleatorio.Next(1,6);
                personaje.Fuerza = (float)aleatorio.Next(1,11);
                personaje.Armadura = (float)aleatorio.Next(1,11);
                break;
            case "Arquero":
                personaje.Nombre = Nombres[aleatorio.Next(20,31)];
                personaje.Apodo = Apodos[aleatorio.Next(20,31)];
                personaje.Velocidad = (float)aleatorio.Next(1,11);
                personaje.Destreza = (float)aleatorio.Next(1,6);
                personaje.Fuerza = (float)aleatorio.Next(1,11);
                personaje.Armadura = (float)aleatorio.Next(1,11);
                break;
            case "Cazador":
                personaje.Nombre = Nombres[aleatorio.Next(30,41)];
                personaje.Apodo = Apodos[aleatorio.Next(30,41)];
                personaje.Velocidad = (float)aleatorio.Next(1,11);
                personaje.Destreza = (float)aleatorio.Next(1,6);
                personaje.Fuerza = (float)aleatorio.Next(1,11);
                personaje.Armadura = (float)aleatorio.Next(1,11);
                break;
            case "Demonio":
                personaje.Nombre = Nombres[aleatorio.Next(40,51)];
                personaje.Apodo = Apodos[aleatorio.Next(40,51)];
                personaje.Velocidad = (float)aleatorio.Next(1,11);
                personaje.Destreza = (float)aleatorio.Next(1,6);
                personaje.Fuerza = (float)aleatorio.Next(1,11);
                personaje.Armadura = (float)aleatorio.Next(1,11);
                break;
            case "Criatura":
                personaje.Nombre = Nombres[aleatorio.Next(50,61)];
                personaje.Apodo = Apodos[aleatorio.Next(50,61)];
                personaje.Velocidad = (float)aleatorio.Next(1,11);
                personaje.Destreza = (float)aleatorio.Next(1,6);
                personaje.Fuerza = (float)aleatorio.Next(1,11);
                personaje.Armadura = (float)aleatorio.Next(1,11);
                break;
            }
            int anio = aleatorio.Next(1723,2024);
            int mes = aleatorio.Next(1,13);
            int dia;
            switch (mes){
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dia = aleatorio.Next(1,32);
                    break;
                case 2:
                    dia = aleatorio.Next(1,29);
                    break;
                default:
                    dia = aleatorio.Next(1,31);
                    break;
            }
            personaje.FechaNac = new DateTime(anio,mes,dia);
            personaje.Edad = (int)(DateTime.Now.Year - personaje.FechaNac.Year);
            return personaje;
        }
    }
}