using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Api.Donation1.Models
{
    [Table("TipoProduto")]
    public class TipoProdutoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TipoProdutoId { get; set; }
        //[Column("NM_TIPO")]
        [Required(ErrorMessage = "O nome do tipo de produto é obrigatório.")]
        [StringLength(55)]
        [MinLength(3)]
        public string NomeTipoProduto { get; set; }
        [Required]
        [StringLength(256)]
        public string? Descricao { get; set; }

        [NotMapped]
        public string? Token { get; set; }


        public TipoProdutoModel()
        {

        }
        public TipoProdutoModel(int id, string nome, string descricao)
        {
            TipoProdutoId = id;
            NomeTipoProduto = nome;
            Descricao = descricao;
        }
    }
}
