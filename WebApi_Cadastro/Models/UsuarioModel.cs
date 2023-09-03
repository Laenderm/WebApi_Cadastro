using System.ComponentModel.DataAnnotations;
using WebApi_Cadastro.Enuns;

namespace WebApi_Cadastro.Models
{
    public class UsuarioModel
    {
        [Key]
        public int ID { get; set; }
        public int Nome { get; set; }
        public int CPF { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public bool ativo { get; set; }       
        public TunoEnum Turno { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime DataAlteracao { get; set; } = DateTime.Now.ToLocalTime();
    }
}
