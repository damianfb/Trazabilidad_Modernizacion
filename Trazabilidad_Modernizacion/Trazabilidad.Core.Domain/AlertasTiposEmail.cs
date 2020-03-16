//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trazabilidad.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class AlertasTiposEmail 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AlertasTiposEmail()
        {
            this.AlertasDestinos = new HashSet<AlertasDestinos>();
        }
        [Key]
        public decimal ateId { get; set; }
        public decimal talId { get; set; }
        public decimal estId { get; set; }
        public string ateTipoSuc { get; set; }
        public string ateAsunto { get; set; }
        public string ateCuerpo { get; set; }
        public decimal atePlazo { get; set; }
        public decimal ateEnvios { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlertasDestinos> AlertasDestinos { get; set; }
        public virtual Estados Estados { get; set; }
        public virtual TipoAlertas TipoAlertas { get; set; }
    }
}