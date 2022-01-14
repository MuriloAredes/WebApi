using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Entities
{
    public class Produtos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long CategoriaId { get; set; }
        public string Nome { get; set; }
        public double PrecoUnitario { get; set; }
        public int QuantidadeEstoque { get; set; }
        public bool Status { get; set; }

        [ForeignKey(nameof(CategoriaId))]
        [InverseProperty(nameof(Categorias.Produtos))]
        public virtual Categorias Categoria { get; set; }
    }
}
