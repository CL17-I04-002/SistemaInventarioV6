using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventarioV6.AccesoDatos.Repositorio.IRepositorio
{
    public interface IRepositorio<T> where T : class
    {
        Task<T> Obtener(int id);
        /*
         * Param 1: genera un filtro y devolverá una bandera, sino se incluye el parámetro no hará nada
         * Param 2: ordena la query y no hará nada sino se incluye
         * Param 3: si es una tabla con llaves foraneas incluimos o no esas propiedades
         * Param 4: cuando queramos acceder a un objeto o lista de objetos que al mismo tiempo queramos modificar, va ser false cuando estemos trabajando con un objeto y al mismo tiempo lo queramos modificar
         */
        Task<IEnumerable<T>> ObtenerTodos(
            Expression<Func<T, bool>> filtro = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string incluirPropiedades = null,
            bool isTracking = true
            );

        Task<T> ObtenerPrimero(
            Expression<Func<T, bool>> filtro = null,
            string incluirPropiedades = null,
            bool isTracking = true
        );
        Task Agregar(T entidad);
        /*
         * Estos ultimos 2 métodos no pueden ser asincronos
         */
        void Remover(T entidad);
        void Remover(IEnumerable<T> entidad);
    }
}
