﻿namespace GuardNull
{
    public class Traditional
    {
        public static void AnyMethod(string anyString)
        {
            if (anyString == null)
                throw new ArgumentNullException(nameof(anyString),"Argument should not be null!");
        }

    }
}