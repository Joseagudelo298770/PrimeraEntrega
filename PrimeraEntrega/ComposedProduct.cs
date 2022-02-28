using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraEntrega
{
    public class ComposedProduct : Product


    {

        public float Discount { get; set; }

        public int Products { get; set; }
        public override decimal ValueToPay()
        {
            return Price * (decimal)Discount;
        }
        public override string ToString()
        {
            return $"Description:{Description}\n+" +
                $"Discount: {Discount}\n" +
                $"Id: {Id}";
        }

    }
}
