namespace Catalog.API.Exceptions
{
    public class ProductNotFoundExaption : Exception
    {
        public ProductNotFoundExaption() : base("Product not found!")
        {
            
        }
    }
}
