using System;


namespace AppInternacao.Enum
{

    [Flags]
    public enum Area : int
    {
       SistemaNeurologico = 1,
       Pupilas = 2,
       RegulacaoTermica = 3,
       Oxigenacao = 4,
       Pele = 5,
       SistemaGastrointestinal = 6, 
       SistemaVascular = 7,
       SistemaAbdominal = 8,
       SistemaUrinario = 9,
       LesaoCompressao = 10,
       GloboPinard = 11,
       ComaGlasgow = 12,
       ControleCateteres = 13,
       PressaoArterial = 14,
    }

}
