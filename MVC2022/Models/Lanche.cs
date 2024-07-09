using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC2022.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }
        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [StringLength(200, ErrorMessage = "O tamanho máximo é 200 caracteres")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Nome do Lanche")]
        public string DescricaoCurta { get; set; }
        [StringLength(500, ErrorMessage = "O tamanho máximo é 500 caracteres")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Descriçao do lanche")]
        public string DescricaoDetalhada { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99,ErrorMessage ="O preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }
        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }




    }
}
