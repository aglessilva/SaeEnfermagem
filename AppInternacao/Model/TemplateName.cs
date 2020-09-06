namespace AppInternacao.Model
{
    public class TemplateName
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdEstruturaFisica { get; set; }
        public string Nome { get; set; }
        public string EstruturaFisica { get; set; }
        public bool? Ativo { get; set; }
        public int? CountExame { get; set; }
    }
}
