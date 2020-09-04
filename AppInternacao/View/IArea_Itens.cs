using AppInternacao.Model;
using System.Collections.Generic;

namespace AppInternacao.View
{
    public interface IArea_Itens
    {
        TemplateName Template { get; set; }
        List<Area_Itens> Area_Itens { set; }
        List<Area_Itens> Area_Itens_Template { set; }
    }
}
