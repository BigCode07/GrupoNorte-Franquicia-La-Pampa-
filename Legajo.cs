//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FullProgram
{
    using System;
    using System.Collections.Generic;
    
    public partial class Legajo
    {
        public int Id { get; set; }
        public Nullable<int> Caja { get; set; }
        public Nullable<int> NroLegajo { get; set; }
        public string ApellidoyNombre { get; set; }
        public string DNI { get; set; }
        public string Estado { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }
        public Nullable<decimal> IdCarpetas { get; set; }
        public string Imagen { get; set; }
        public string Usuario { get; set; }
        public Nullable<System.DateTime> FechaCarga { get; set; }
    }
}