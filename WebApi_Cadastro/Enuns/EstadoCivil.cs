using System.Text.Json.Serialization;

namespace WebApi_Cadastro.Enuns
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EstadoCivil
    {
        Solteiro,
        Casado,
        Divorciado,
        Viuvo,
    }
}
