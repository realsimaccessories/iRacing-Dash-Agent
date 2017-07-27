using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRacing_Dash_Agent
{
    class RegistryFunctions
    {
        private Type type;

        private string readRegistry (RegistryKey registryKey)
        {
            string value = null;
            type = registryKey.GetType();
            if (type.FullName == "")
            {

            }
            return value;
        }
    }
}
