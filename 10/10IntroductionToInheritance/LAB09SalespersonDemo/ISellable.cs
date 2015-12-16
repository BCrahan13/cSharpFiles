using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB09SalespersonDemo
{
    class ISellable
    {
        public interface Sellable
        {
            void SalesSpeech();
            void MakeSale(int val);
        }
    }
}
