﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.Entities
{
    public class Libreria
    {
        public string Libreriaid { get; set; }

        public List<LocalLibreria> LocalLibrerias { get; set; }

        public List<Empleado> Empleados { get; set; }

    }
}
