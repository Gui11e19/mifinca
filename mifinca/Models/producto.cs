//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mifinca.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class producto
    {
        public int codigo_producto { get; set; }
        public int id_bodega { get; set; }
        public string foto_producto { get; set; }
        public string nombre_prod { get; set; }
        public int extension { get; set; }
        public string localizacion { get; set; }
    
        public virtual bodega bodega { get; set; }
    }
}
