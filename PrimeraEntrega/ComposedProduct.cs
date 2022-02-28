
namespace PrimeraEntrega
{
    public class ComposedProduct : Product


    {

        public float Discount { get; set; }

        public List<Product> Products { get; set; } 

    
        public override decimal ValueToPay()
            
        {
            decimal accumulatedvalue = 0;

            foreach (Product Products in Products)
            
            accumulatedvalue  += Products.ValueToPay();

            

            return accumulatedvalue - accumulatedvalue * (decimal)Discount;
        }

        
        public override string ToString()
        {
            String message= "";
            foreach (Product products in Products)
            message  += products.Description+", ";

            return $"  {Id}  {Description}" +

                $"\n\tProducts...:  {message} "+
                $"\n\tDiscount...: {$"{Discount:P2}",13}" +
                $"\n\tValue......: {ValueToPay():C2}";
        }

    }
}



