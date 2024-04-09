namespace blazorModulos.Models
{
    public class ModuloModel
    {
        public int idModulo { get; set; }
        public string Titulo { get; set; }
        public string Version { get; set; }

        public List<PreguntasxmoduloModel> Preguntasxmodulos { get; set; } = new List<PreguntasxmoduloModel>();

    }
}
