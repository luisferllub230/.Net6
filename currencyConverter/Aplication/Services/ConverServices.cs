using Aplication.Enums;
using Aplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Services
{
    public sealed class ConverServices
    {
        private ConverServices()
        {

        }

        public static ConverServices Instance { get; } = new();


        private int totalConvert;
        private string ConverterName;

        public void takeData(CoverterViewModel cs) 
        {
            switch (cs.CoinValueSelected)
            {
                case (int)ConvertEnum.PSrdToDollar:
                    totalConvert = (int)(cs.CoinTypeTotal * 0.019);
                    ConverterName = "Dollars";
                    break;

                case (int)ConvertEnum.DollarToPSrd:
                    totalConvert = (int)(cs.CoinTypeTotal * 55);
                    ConverterName = "Pesos RD";
                    break;

                case (int)ConvertEnum.EuroToPSrd:
                    totalConvert = (int)(cs.CoinTypeTotal * 53);
                    ConverterName = "Pesos RD";
                    break;

                case (int)ConvertEnum.PSrdToEuro:
                    totalConvert = (int)(cs.CoinTypeTotal * 0.019);
                    ConverterName = "Euros";
                    break;
            }
        }

        public int getTotalConvert() 
        {
            return totalConvert;
        }

        public string getConverterName() 
        {
            return ConverterName;
        }
    }
}
