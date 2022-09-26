using Aplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Repositori
{
    public sealed class Repositori
    {
        private Repositori() 
        {

        }

        public static Repositori Instance { get; } = new();
        public ZodiacListViewModel zl = new();
    }
}
