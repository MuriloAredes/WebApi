using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Entities
{
    public class Categorias
    {
        public Categorias()
        {
            Produtos = new HashSet<Produtos>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Nome { get; set; }

        [InverseProperty("Categoria")]
        public virtual ICollection<Produtos> Produtos { get; set; }
    }
}
