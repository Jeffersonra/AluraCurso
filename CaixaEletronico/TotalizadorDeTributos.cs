﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffDev
{
    class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void Acumula(ITributavel cp)
        {
            this.Total += cp.CalculaTributo();
        }
    }
}
