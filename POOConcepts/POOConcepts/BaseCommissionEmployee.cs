﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts
{
    public class BaseCommissionEmployee: CommissionEmployee
    {
        public decimal Base { get; set; }

        public override decimal GetValuetoPay()
        {
            return base.GetValuetoPay() + Base;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tBase.................: {$"{Base:C2}",18}"; //P2 es un formato de porcentaje
                
        }
    }
}
