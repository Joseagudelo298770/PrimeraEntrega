using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraEntrega
{
    public class FixedPriceProduct : Product

    {


        public override decimal ValueToPay()
        {

            return Price + (Price * (decimal)Tax);
        }

        public override string ToString()
        {
            return $"{base.ToString()}"+
                 $"\n\tValue: {ValueToPay():C2} "
                ;
        }

    }
}
