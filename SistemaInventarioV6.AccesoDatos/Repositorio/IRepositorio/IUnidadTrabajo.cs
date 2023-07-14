using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventarioV6.AccesoDatos.Repositorio.IRepositorio
{
    /// IDisposable nos servirá para liberar recursos
    public interface IUnidadTrabajo : IDisposable
    {
        IBodegaRepositorio Bodega { get; }
        /// Porque solo tenemos el método SaveChange en nuestras interfaces concretas, lo alojamos acá para que los demás métodos del repositorio sean aplicados
        Task Guardar();
    }
}
