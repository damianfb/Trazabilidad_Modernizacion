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
	using System.ComponentModel.DataAnnotations.Schema;

	public partial class Conversiones 
    {
		[Key, Column(Order = 0)]
		public string concepto_cod { get; set; }
		[Key, Column(Order = 1)]
		public string codigo_ORIGEN { get; set; }
		[Key, Column(Order = 2)]
		public string codigo_DESTINO { get; set; }
        public string concepto_descripcion { get; set; }
    }
}
