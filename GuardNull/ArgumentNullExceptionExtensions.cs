namespace GuardNull
{
    public static class ArgumentNullExceptionExtensions
    {
        public static void ThrowIfNull(this ArgumentNullException _, object? argument, string? paramName, string? message)
        {
            if (argument == null)  throw new ArgumentNullException(paramName, message);
        }

    }
}
