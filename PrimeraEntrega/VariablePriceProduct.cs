using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraEntrega
{
    public class VariablePriceProduct : Product

    {

        public string Measurement { get; set; }

        public float Quantity { get; set; }


        public override decimal ValueToPay()
        {
            return (Price + (Price * (decimal)Tax)) * (decimal)Quantity ;
        }
        public override string ToString()
        {
            return
                $"{Id}  {Description}" +
                $"\n\t Measurement: {Measurement}"+
                $"\n\t Quantity: {Quantity:F2}" +
                $"\n\tPrice: {Price:C2} " +
                $"\n\tTax: {Tax.ToString("0.00%")}"+
                $"\n\t Value To Pay: {ValueToPay():C2}" 
   
                ;
         
        }

    }
}
