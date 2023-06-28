using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaInventarioV6.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventarioV6.AccesoDatos.Configuracion
{
    /// Fluent API nos sirve para administrar en una sola clase nuestras clases de dominio, en ellas podemos configurar los campos requeridos en la BD
    /// hasta las relaciones entre otras tablas (ManyToOne, OneToMany, etc)
    public class BodegaConfiguracion : IEntityTypeConfiguration<Bodega>  
    {
        public void Configure(EntityTypeBuilder<Bodega> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Nombre).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Descripcion).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Estado).IsRequired().HasMaxLength(100);
        }
    }
}
