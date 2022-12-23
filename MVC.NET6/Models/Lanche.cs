using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.NET6.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [StringLength(80, MinimumLength = 10, ErrorMessage = "O tamanho mínimo é {1} e o tamanho máximo é {2}")]
        [Required(ErrorMessage = "Informe o nome do lanche")]
        [Display(Name = "Nome do Lanche")]
        public string Nome { get; set; }

        [StringLength(200, MinimumLength = 20, ErrorMessage = "O tamanho mínimo é {1} e o tamanho máximo é {2}")]
        [Required(ErrorMessage = "Informe a descrição do lanche")]
        [Display(Name = "Descrição do lanche")]
        public string DescricaoCurta { get; set; }

        [StringLength(300, MinimumLength = 30, ErrorMessage = "O tamanho mínimo é {1} e o tamanho máximo é {2}")]
        [Required(ErrorMessage = "Informe a descrição detalhada do lanche")]
        [Display(Name = "Descrição detalhada do lanche")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }

        [StringLength(400, ErrorMessage = "O tamanho máximo é {1}")]
        [Display(Name = "Caminho da imagem URL")]
        public string ImagemUrl { get; set; }

        [StringLength(400, ErrorMessage = "O tamanho máximo é {1}")]
        [Display(Name = "Caminho da imagem URL em miniatura")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        // Propriedades de navegação -> virtual == padrão?
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
