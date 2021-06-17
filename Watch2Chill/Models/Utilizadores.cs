using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Watch2Chill.Models
{
    public class Utilizadores
    {
        public Utilizadores()
        {
            ListaDeVideos = new HashSet<UtilizadoresVideos>();
        }
        /// <summary>
        /// Atributo único para cada utilizador. Este atributo identifica um dado utilizador com um Id específico
        /// </summary>
        [Key]
        public int Id { get; set; }


        /// <summary>
        /// Atributo nome do utilizador. Este atributo é de preenchimento obrigatório
        /// </summary>

        [Required(ErrorMessage = "O Nome é de preenchimento obrigatório")]
        public string Nome { get; set; }


        /// <summary>
        /// Identifica o email do utilizador. Este campo é de preenchimento obrigatório e que tem de respeitar um conjunto de regras de validação
        /// </summary>
        [Required(ErrorMessage = "O Email de preenchimento obrigatório")]
        [StringLength(150, ErrorMessage = "O {0} não pode ter mais de {1} caracteres.")]
        [EmailAddress(ErrorMessage = "o {0} introduzido não é válido")]
        public string Email { get; set; }

        
        /// <summary>
        /// Identifica a morada do utilizador. Este campo é de preenchimento obrigatório
        /// </summary>
        [Required(ErrorMessage = "A Morada é de preenchimento obrigatório")]
        public string Morada { get; set; }

        public string CodPostal { get; set; }
        /// <summary>
        /// Identifica o sexo do Utilizador "M/F"
        /// </summary>
        public string Sexo { get; set; }

        /// <summary>
        /// Atributo de preenchimento obrigatório. A idade deve ser igual ou superior a 18 anos, para efeito de pagamento do serviço.
        /// </summary>
        [Required(ErrorMessage = "A Data de Nascimento é de preenchimento obrigatório")]
        public DateTime DataNascimento{ get; set; }

        
        public ICollection<UtilizadoresVideos> ListaDeVideos { get; set; }
    }
}
