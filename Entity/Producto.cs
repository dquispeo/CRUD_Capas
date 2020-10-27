using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Producto
    {
        public int IdProducto{ get; set; }
        public string NombreProducto { get; set; }
        public int IdProveedor{ get; set; }
        public int IdCategoria{ get; set; }
        public string CantidadPorUnidad { get; set; }
        public int PrecioUnidad { get; set; }
        public int UnidadesExistentes { get; set; }
        public int UnidadesPedidas { get; set; }
        public int NivelNuevoPedido { get; set; }
        public bool Suspendido { get; set; }
        public string CategoriaProducto { get; set; }
    }
}
