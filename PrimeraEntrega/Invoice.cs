

namespace PrimeraEntrega
{
    public class Invoice : IPay
    {

        private new List<Product> _products;


        public Invoice()
        {
            _products = new List<Product>();

            


        }
     
       public List<Product> AddProduct(Product product)
        {
            {
                _products.Add(product);
            }
            
            
            return _products;
        }
      

        public decimal ValueToPay()
        {
            decimal totalInvoice = 0;
            foreach (Product product in _products)
                totalInvoice += product.ValueToPay();
            return totalInvoice;
           
            
        }

        public override string ToString()
        {
            String message = null;
            foreach (Product product in _products)
                message += product+"\n";

            return

                $"RECEIPT"+
                $"\n----------------------------------------------------"+
                $"\n{message}"  +
                $"\t            ===============" +
                $"\n\tTotal:      {ValueToPay():C2}";

               
        }
    }
}
