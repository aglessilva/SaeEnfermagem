using AppInternacao.Model;
using System.Collections.Generic;

namespace AppInternacao.View
{
    public interface ITemplateName
    {
        TemplateName templateName { get; set; }
        List<TemplateName> templates { set; }
        List<EstruturaFisica> estruturaFisicas { set; }
    }
}
