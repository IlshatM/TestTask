namespace Square.Exceptions
{
    public class TriangleInvalidException : ApplicationException
    {
        public TriangleInvalidException(string? specificExceptionMessage = null) : base(
            $"Triangle is invalid. {specificExceptionMessage}")
        {
        }
    }
}
