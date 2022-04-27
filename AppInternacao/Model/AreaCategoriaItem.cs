namespace AppInternacao.Model
{
    public class AreaCategoriaItem
    {

        public int Id { get; set; }
        public int IdArea { get; set; }
        public int IdAreaItem { get; set; }
        public int ValorItem { get; set; }
        public string Descricao { get; set; }
        public bool? IsAtivo { get; set; }
    }
}
