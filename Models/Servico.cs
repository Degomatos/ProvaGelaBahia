using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProvaGelaBahia.Models
{
    [Table("servicos")]
    public class Servico
    {
        [Key]
        public int IdServicos { get; set; }
        // public DateTime Data_Servico { get; set; }

        [Display(Name = "Data do Serviço")]
        public DateTime data_hora_servico { get; set; }

        [Display(Name = "Valor do Serviço")]
        public double valor_Servico { get; set; }

        [Display(Name = "Status")]
        public string status { get; set; }

        [Display(Name = "Id do Serviço")]
        [ForeignKey("Tiposervico")]
        public int tipoServico_idtiposervico { get; set; }

        [Display(Name = "Detalhe da Manutenção")]
        public string detalhe_servico { get; set; }
    }
}