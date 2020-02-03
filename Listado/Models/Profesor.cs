using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Listado.Models
{
    public class Profesor
    {
        [Key]
        public int idprofesor { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public int Cedula { get; set; }
    
    }
}