using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoBase.Models
{
    public class Aluno
    {
        [Required(ErrorMessage = "Informe o nome do Aluno!")]
        [Display(Name = " Nome do Aluno:")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a idade do Aluno!")]
        [Range(8, 50, ErrorMessage = "A idade deve estar entre 8 e 50 anos!")]
        [Display(Name = " Idade do Aluno:")]
        public int Idade { get; set; }

    }
}