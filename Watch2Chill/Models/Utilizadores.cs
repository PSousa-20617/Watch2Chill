using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Watch2Chill.Models
{
    public class Utilizadores
    {
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
        /// Identifica o email do utilizador. Este campo é de preenchimento obrigatório e que 
        /// </summary>
        [Required(ErrorMessage = "O Email de preenchimento obrigatório")]
        [StringLength(150, ErrorMessage = "O {0} não pode ter mais de {1} caracteres.")]
        [EmailAddress(ErrorMessage = "o {0} introduzido não é válido")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'+/=?^_`{|}~-]+(?:.[a-z0-9!#$%&'+/=?^_`{|}~-]+)@(?:[a-z0-9](?:[a-z0-9-][a-z0-9])?.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        ErrorMessage = "Por favor, insira o endereço de email correto")]
        public string Email { get; set; }

        
        [Required(ErrorMessage = "A Morada é de preenchimento obrigatório")]
        public string Morada { get; set; }

        public string Sexo { get; set; }

        [Required(ErrorMessage = "A Data de Nascimento é de preenchimento obrigatório")]
        public DateTime Data_nascimento{ get; set; }

        public string Tipo { get; set; }
    }
}
