using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Problems.Util
{
    public static class CoreHelper
    {
        public static IEnumerable<Type> GetImplementors(Type interfaceType)
        {
            if (interfaceType == null) return null;

            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => interfaceType.IsAssignableFrom(p) && p.IsClass);

            return types;
        }
    }
}
