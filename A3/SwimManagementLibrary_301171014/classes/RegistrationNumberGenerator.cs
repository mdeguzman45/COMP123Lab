using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimManagementLibrary_301171014.classes
{
    public static class RegistrationNumberGenerator
    {
        private static uint nextRegistrationNumber;

        public static uint GetNext()
        {
            return ++nextRegistrationNumber;
        }
    }
}
