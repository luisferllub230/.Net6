using Aplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Services
{
    public sealed class LoanCalculatorServices
    {
        private LoanCalculatorServices() 
        {

        }

        public static LoanCalculatorServices Instance { get; } = new();

        private double _cuotaM = 0;

        public void calculator(LoanCalculatorViewModel lc) 
        {
            if (lc.PrestamoOpciones == 1) 
            {
                _cuotaM = ((lc.Monto * 0.22) + lc.Monto) / Convert.ToDouble(lc.CoutoMensual); 
            }
            if (lc.PrestamoOpciones == 2)
            {
                _cuotaM = ((lc.Monto * 0.12) + lc.Monto) / Convert.ToDouble(lc.CoutoMensual);
            }
            if (lc.PrestamoOpciones == 3)
            {
                _cuotaM = ((lc.Monto * 0.08) + lc.Monto) / Convert.ToDouble(lc.CoutoMensual);
            }
        }

        public double getData() 
        {
            return _cuotaM;
        }

    }
}
