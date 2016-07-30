using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//para modelado de datos directamente se usa esto
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{

    public class SurveyModels
    {

        [DisplayName("Nombre")]
        [Required]
        public string nombre { get; set; }

        [DisplayName("Precio")]
        [Required]
        public double precio { get; set; }

        [DisplayName("Descripción")]
        [Required]
        public string descripcion { get; set; }

    }

    public class SurveyA
    {
        public List<SurveyModels> lProducto = new List<SurveyModels>();

        //public Producto()
        //{
        //    /* Precargar lista de Producto */
        //    lProducto.Add(new SurveyModels
        //    {
        //        nombre = "Ipod Touch",
        //        precio = 5500,
        //        descripcion = "32 G",

        //    });

        //    /* Precargar lista de Producto */
        //    lProducto.Add(new SurveyModels
        //    {
        //        nombre = "PS3 Slim",
        //        precio = 55500,
        //        descripcion = "320 G",

        //    });
        //}

        // Metodo para crear equipos
        public void CreateProducto(SurveyModels producto)
        {
            lProducto.Add(producto);
        }

        public SurveyModels GetProducto(string CodigoActivo)
        {
            SurveyModels producto = null;

            foreach (SurveyModels pr in lProducto)
            {
                producto = pr;
            }
            return producto;
        }

        public void EditProducto(SurveyModels producto)
        {
            foreach (SurveyModels pr in lProducto)
            {
                if (pr.nombre == producto.nombre)
                {
                    lProducto.Remove(pr);
                    lProducto.Add(producto);
                    break;
                }
            }
        }

        public SurveyModels DeleteProducto(string nombre)
        {
            SurveyModels prModel = null;

            foreach (SurveyModels pr in lProducto)
            {
                if (pr.nombre == nombre)
                {
                    prModel = pr;
                }
                lProducto.Remove(prModel);
            }

            return prModel;
        }

    }
}
