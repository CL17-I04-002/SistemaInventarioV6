using SistemaInventarioV6.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventarioV6.AccesoDatos.Repositorio.IRepositorio
{
    public interface IBodegaRepositorio : IRepositorio<Bodega>
    {
        /// Este método se trabajara individual ya que cada entidad tiene sus propias propiedades
        void Actualizar(Bodega bodega);
    }
}
