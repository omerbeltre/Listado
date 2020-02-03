using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Listado.Models
{
    public class Estudiante
    {
        [Key]
        public int idestudiante { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public int Matricula { get; set; }
        public String Tecnico { get; set; }
    }
}