using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DictionaryOfTypes.Clients;

namespace DictionaryOfTypes.Benchmarking
{
    // Exist, because of the issue with loading .Net Core assemblies at T4.
    // Link: https://developercommunity.visualstudio.com/content/idea/881587/support-loading-of-net-core-libraries-in-t4-templa.html
    public static class InterfacesFinder
    {
        public static string[] GetClientInterfacesNames()
        {
            return Assembly.GetAssembly(typeof(ChatRoomClientAttribute))!.DefinedTypes.Where(type => !type.IsInterface && !type.IsAbstract && type.CustomAttributes
                    .Any(attrData => attrData.AttributeType == typeof(ChatRoomClientAttribute)))
                .Select(type => type.ImplementedInterfaces.First())
                .Select(type => type.Name)
                .ToArray();
        }
    }
}