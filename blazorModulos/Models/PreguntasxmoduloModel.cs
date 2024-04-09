namespace blazorModulos.Models
{
    public class PreguntasxmoduloModel
    {
        public int IdPregunta { get; set; }

        public string Texto { get; set; } = null!;

        public int Modulo { get; set; }

        public int Posicion { get; set; }

        public List<Respuestasxmodulo> Respuestasxmodulos { get; set; } = new List<Respuestasxmodulo>();

    }
}
