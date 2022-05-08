using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardNull
{
    public class UsingGuard
    {
        public static void AnyMethod(string anyString)
        {
            Guard.ThrowIfArgumentNull(anyString);
        }
        public static void AnyExtendedMethod(string anyString)
        {
            ArgumentNullException.ThrowIfNull(anyString);
        }
    }
}
