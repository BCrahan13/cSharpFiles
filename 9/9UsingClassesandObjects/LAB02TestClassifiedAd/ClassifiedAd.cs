using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02TestClassifiedAd
{
    class ClassifiedAd
    {
        //Instance Fields
        private string category;
        private int numWords;
        private double price;
        //CONSTANT
        public const double PRICE_PER_WORD = 0.09;

        public ClassifiedAd()
        {
            category = "";
            numWords = 0;
            price = 0;
        }
        public ClassifiedAd(string category, int numWords)
        {
            this.category = category;
            this.numWords = numWords;
            price = CalcTotal(numWords);
        }

        private double CalcTotal(int numWords)
        {
            double totalPrice = numWords * PRICE_PER_WORD;
            return totalPrice;
        }

        //Properties
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
        public int NumWords
        {
            get
            {
                return numWords;
            }
            set
            {
                numWords = value;
            }
        }
        //Property that is read-only with only a Get Accessor
        public double Price
        {
            get
            {
                return price;
            }
        }
    }
}
