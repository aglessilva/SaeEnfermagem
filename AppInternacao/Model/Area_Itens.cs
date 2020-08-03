using AppInternacao.Enum;

namespace AppInternacao.Model
{
    public class Area_Itens
    {
        public int Id { get; set; }
        public Area IdArea { get; set; }
        public int IdEstruturaFisica { get; set; }
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
    }
}
