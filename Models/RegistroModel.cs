using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Registroapp.Models
{
    public class RegistroModel
    {
        [Display(Name = "Estudiante", Prompt = "Nombre de Estudiante")]
        public string? Estudiante { get; set; }

        [Display(Name = "Curso", Prompt = "Cursos")]
        public string? Curso { get; set; }

        [Display(Name = "Matematica", Prompt = "Matematica")]
        public bool Matematica { get; set; }
        
        [Display(Name = "Lenguaje", Prompt = "Lenguaje")]
        public bool Lenguaje { get; set; }

        [Display(Name = "Historia", Prompt = "Historia")]
        public bool Historia { get; set; }
    }
}