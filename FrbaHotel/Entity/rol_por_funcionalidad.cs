//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FrbaHotel.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class rol_por_funcionalidad
    {
        public int id_rol_por_funcionalidad { get; set; }
        public Nullable<int> id_rol { get; set; }
        public Nullable<int> id_funcionalidad { get; set; }
    
        public virtual funcionalidad funcionalidad { get; set; }
        public virtual rol rol { get; set; }
    }
}
