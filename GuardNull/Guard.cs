using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardNull
{
    public static class Guard
    {
        public static void ThrowIfNullArgument(object argument, string paramName, string message)
        {
            if (argument == null)   
                throw new ArgumentNullException(paramName, message);
        }

        public static void ThrowIfArgumentNull(object argument, string message)
        {
            if (argument == null)
                throw new ArgumentNullException(message);
        }
        public static void ThrowIfArgumentNull(object argument)
        {
            if (argument == null)
                throw new ArgumentNullException();
        }

    }
}
