using Playground.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Library.Core
{
    public static class Helper
    {
        #region System Methods

       

        public static void InvokeMethod(Type type, string methodName)
        {
            object instance = Activator.CreateInstance(type);
            MethodInfo method =
                type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            method.Invoke(instance, null);
        }

        #endregion

        public static void InsertNewLines(int numberOfLines = 1)
        {
            var outputStr = string.Empty;

            for (int i = 0; i < numberOfLines; i++)
            {
                outputStr += Environment.NewLine;
            }

            Console.Write(outputStr);
        }

        
    }
}
