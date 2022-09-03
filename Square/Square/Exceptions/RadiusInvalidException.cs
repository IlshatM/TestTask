namespace Square.Exceptions
{
    public class RadiusInvalidException : ApplicationException
    {
        public RadiusInvalidException(string? specificExceptionMessage = null) : base(
            $"Radius has invalid value. {specificExceptionMessage}")
        {
        }
    }
}
