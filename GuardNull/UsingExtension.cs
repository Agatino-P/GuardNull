using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardNull
{
    internal class UsingExtension
    {
        public static void AnyMethod(string anyString)
        {
            ArgumentNullException.ThrowIfNull(anyString);
        }
    }
}
