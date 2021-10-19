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
        [Required(ErrorMessage = "Ingrese una descripción")]
        [MinLength (3,ErrorMessage = "Ingrese minimo 3 caracteres")]
        [MaxLength(20, ErrorMessage = "Ingrese un máximo de 20 caracteres")]
        public string Descripcion { get; set; }


        [Required (ErrorMessage = "Ingrese precio")]
        [Range(0,10000, ErrorMessage = "Ingrese precio entre 0 y 10000")]
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }

        [Display(Name = "Imagen")]

        public string UrlImagen { get; set; }

        public bool Activo { get; set; }
    }
}

