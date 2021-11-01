using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsasCharms.BL
{
    public class Producto
    {
        public Producto()
        {
            Activo = true;

        }
        public int Id { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "Ingrese la descripción")]
        [MinLength(3, ErrorMessage ="Ingrese mínimo 3 caracteres")]
        [MaxLength(25, ErrorMessage = "Ingrese máximo 25 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Ingrese un precio")]
        [Range(0, 3000, ErrorMessage = "Ingrese un precio entre 0 y 3,000")]
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }

        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }

        public bool Activo { get; set; }
    }
}

