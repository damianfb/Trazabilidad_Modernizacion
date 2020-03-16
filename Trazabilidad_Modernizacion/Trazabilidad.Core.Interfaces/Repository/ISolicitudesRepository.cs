﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trazabilidad.Core.Domain;

namespace Trazabilidad.Core.Interfaces.Repository
{
    public interface ISolicitudesRepository : IBaseRepository<Solicitudes>
    {

        Solicitudes ObtenerSolicitud(decimal solId);
    }
}
 