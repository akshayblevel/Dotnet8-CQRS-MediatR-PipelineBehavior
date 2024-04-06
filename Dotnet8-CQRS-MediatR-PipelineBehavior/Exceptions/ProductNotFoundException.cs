namespace Dotnet8_CQRS_MediatR_PipelineBehavior.Exceptions
{
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException() : base("Product not found!")
        {

        }
    }
}
