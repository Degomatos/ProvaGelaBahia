using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProvaGelaBahia.Models
{
    [Table("TipoServico")]
    public class TipoServico
    {
        [Key]
        [Display(Name = "Id do Seviço")]
        public int IdTipoServico { get; set; }

        [Display(Name = "Nome do Serviço")]
        public string Nome_Servico { get; set; }
    }
}