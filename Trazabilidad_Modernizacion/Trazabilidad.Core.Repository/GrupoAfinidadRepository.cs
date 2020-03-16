﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.Core.Domain;
using Trazabilidad.Core.Interfaces.Repository;

namespace Trazabilidad.Core.Repository
{
	public class GrupoAfinidadRepository : BaseRepository<GruposAfinidad>, IGrupoAfinidadRepository
	{
		public GrupoAfinidadRepository(ITarjetasWebContext context) : base(context)
		{ }

	}
}
