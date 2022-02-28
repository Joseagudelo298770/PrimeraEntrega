namespace PrimeraEntrega
{
    public abstract class Product
    {

        public string Description { get; set; }
        public int Id { get; set; }

        public decimal Price { get; set; }

        public float Tax {
            
            
            get; 
            
            
            set
                
           ; }

        public abstract decimal ValueToPay();

        public override string ToString()
        {
            return $"  {Id}  {Description}" +
                $"\n\tPrice......: {$"{Price:C2}",10}" +
                $"\n\tTax........: {$"{Tax.ToString("0.00%")}",12}";
        }

    }
}
