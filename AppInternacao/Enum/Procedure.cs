﻿namespace AppInternacao.Enum
{
    public enum Procedure
    {
        VAZIO = 0,
        SP_ADD_UPDT_PACIENTE = 1,

        SP_VALIDA_CLIENTE = 2,

        SP_GET_PACIENTE = 3,

        SP_GET_PACIENTE_DIAGNOSTICO = 4,

        SP_GET_SETOR = 5,

        SP_ADD_UPD_QUARTO = 6,

        SP_GET_QUARTOS = 7,

        SP_VALIDA_QUANRTO = 8,

        SP_DEL_QUARTO = 9,

        SP_ADD_UPD_LEITO = 10,

        SP_GET_LEITO = 11,

        SP_DEL_LEITO = 12,

        SP_GET_QUARTOS_BYNAME = 13,

        SP_STATUS_INTERNACAO = 14,

        SP_ADD_HISTORICO_ENFERMAGEM = 15,

        SP_ADD_UPDT_USUARIO = 16,

        SP_UPDT_SENHA_USUARIO = 17,

        SP_AUTENTICAR_USUARIO = 18,

        SP_GET_USUARIOS = 19,

        TB_HISTORICO_ENFERMAGEM = 20,

        SP_GET_ESTRUTURA_FISICA = 21,

        SP_GET_STATUS_LEITO = 24,

        SP_ADD_ALTERACAO_LEITO_PACIENTE = 25,

        SP_ADD_PRESCRICAO =  26,

        SP_DEL_PRESCRICAO = 27,

        SP_ADD_DATE = 28,

        SP_DEL_DATE_PRESCRICAO = 29,

        SP_GET_PRESCRICAO = 30,

        SP_GET_CHAVE_PRESCRICAO = 31,

        SP_ADD_CHAVE_PRESCRICAO = 32,

        SP_GET_CICLO = 33,

        SP_DEL_CHAVE_PRESCRICAO = 34,

        SP_ADD_JUSTIFICATIVA = 35,

        SP_CHK_CPF_USUARIO = 38,

        SP_ADD_UPDT_APARTAMENTO = 39,

        SP_GET_APARTAMENTO = 40,

        SP_GET_DOMINIO = 41,

        SP_GET_CLASSE = 42,

        SP_GET_DIAGNOSTICO = 43,

        SP_GET_FATORES_RELACIONADOS = 44,

        SP_GET_CARACTERISTICA_DEFINIDORA = 45,

        SP_GET_CONDICOES_ASSOCIADA = 46,

        SP_GET_FATORES_RISCO = 47,

        SP_GET_POPULACAO_RISCO = 48,

        SP_GET_JUSTIFICATIVA = 49,

        SP_GET_CATEGORIAS_AREA = 50,

        SP_GET_CATEGORIAS_AREA_ITEMS = 51,

        SP_ADD_NAME_TEMPLATE_EXAME_FISICO = 52,

        SP_GET_NAME_EXAME_FISICO = 53,

        SP_GET_TEMPLATE_EXAME_FISICO = 54,

        SP_ADD_EXAME_FISICO = 55,

        SP_GET_NIC_CLASSIFICACAO = 56,

        SP_GET_NIC_INDICADORES = 57
    }
}
