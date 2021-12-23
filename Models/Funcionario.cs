using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProvaGelaBahia.Models
{
    [Table("Funcionario")]
    public class Funcionario
    {
        [Key]
        public int IdFuncionario { get; set; }

        [Display(Name = "Nome do Funcionario")]
        public string Nome_Funcionario { get; set; }
        
        [Display(Name = "CPF do Funcionario")]
        public string Cpf_Funcionario { get; set; }

        [Display(Name = "Salário")]
        public double Salario { get; set; }

        [Display(Name = "Comissão")]
        public double Comissao { get; set; }

        [Display(Name = "Status")]
        public string status { get; set; }

        [Display(Name = "Id do Serviço")]
        public int Servicos_IdServicos { get; set; }
    }
}